﻿using MageBot.Util.Enums.Internal;
using Util.Util.Text.Log;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading;

namespace MageBot.Core.Path
{
    public class PathManager
    {
        #region Fields
        public Account.Account Account { get; set; }
        public string Path;
        public string PathName { get; set; }
        private string Current_Map { get; set; }
        private string Current_Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        public bool Launched { get; set; }
        public List<Action> ActionsStack { get; set; }
        public Action Current_Action { get; set; }
        public List<string> ListActions { get; set; }
        public Queue<string> WorkingActionsQueue { get; set; }
        public string CurrentAction { get; set; }
        private string flag { get; set; }
        private List<string> m_content { get; set; }
        private List<PathCondition> conditions { get; set; }
        private bool Stop { get; set; }

        public static readonly IList<String> flags = new ReadOnlyCollection<string>
        (new List<String> { "<Move>", "<Fight>", "<Gather>", "<Dialog>" });

        public static readonly IList<String> Endflags = new ReadOnlyCollection<string>
        (new List<String> { "</Move>", "</Fight>", "</Gather>", "</Dialog>" });

        public static readonly IList<String> Actions = new ReadOnlyCollection<string>
        (new List<String> { "exchange(", "npc(", "cell(", "object(", "zaap(", "zaapi(", "use(", "move(" });

        public static readonly IList<char> operateurs = new ReadOnlyCollection<char>
        (new List<char> { '<', '>', '=' });
        #endregion

        #region Constructors
        public PathManager(Account.Account account, string Path, string name)
        {
            Account = account;
            this.Path = Path;
            PathName = name;
            m_content = File.ReadAllLines(Path).ToList();
        }

        #endregion

        #region Public methods
        /// <summary>
        /// Start the path's parsing
        /// </summary>
        public void Start()
        {
            Account.Log(new BotTextInformation("Path started"), 1);
            Launched = true;
            Stop = false;
            //Account.WatchDog.StartPathDog();
            ParsePath();
        }

        /// <summary>
        /// Stop the path and clear the current actions stack.
        /// </summary>
        public void StopPath()
        {
            Stop = true;
            Launched = false;
            ClearStack();
            ListActions.Clear();
            WorkingActionsQueue.Clear();
            CurrentAction = string.Empty;
            Current_Action = null;
            //Account.WatchDog.StopPathDog();
        }

        /// <summary>
        /// Search for the answer of a given npc's question in the path and send it.
        /// </summary>
        public void SearchReplies(string question)
        {
            if (Account.Npc != null)
            {
                StreamReader sr = new StreamReader(Path);
                int flag = 0;
                while (sr.Peek() > 1)
                {
                    string line = sr.ReadLine();
                    if (line.Contains("</Dialog>"))
                        break;
                    if (line.Contains("<Dialog>"))
                        flag = 1;
                    if (flag == 1 && question.Contains(line.Split('|')[0]))
                    {
                        string[] l = line.Split('|');
                        foreach (MageBot.Core.Npc.NpcReply rep in Account.Npc.Replies)
                        {
                            string resp = rep.GetText();
                            if (resp.Contains(l[1]))
                            {
                                Account.Npc.SendReply(rep.Id);
                                Account.Log(new BotTextInformation("Envoi de la réponse : " + rep.GetText()), 1);
                                sr.Close();
                                return;
                            }
                        }
                    }
                }
                sr.Close();
                Account.Log(new ErrorTextInformation("Aucune réponse disponible dans le trajet"), 0);
            }
        }

        /// <summary>
        /// Perform the action associed with the current path's flag.
        /// </summary>
        public void PerformFlag()
        {
            if (Account.State == Status.Fighting)
                return;
            switch (Current_Flag)
            {
                case "<Fight>":
                    // Start a fight, the actions will be carried out after the fight
                    FightFlag();
                    break;
                case "<Gather>":
                    //We collect the map, the actions will be carried out after the harvest
                    GatherFlag();
                    break;
                default:
                    PerformActionsStack();
                    break;
            }
            Account.WatchDog.Update();
        }

        private void GatherFlag()
        {
            bool haveSomethingToGather;
            do
            {
                haveSomethingToGather = Account.PerformGather();
            } while (haveSomethingToGather);
            PerformActionsStack();
        }

        private void FightFlag()
        {
            if (Account.IsMaster && Account.MyGroup != null && Account.Fight != null)
            {
                WaitAccountsFightOrRegen();
                if (!Account.Fight.SearchFight())
                    PerformActionsStack();
            }
        }

        private void WaitAccountsFightOrRegen()
        {
            do
            {
                Account.Wait(1);
            } while (Account.MyGroup.Accounts.Any(acc => acc.State != Status.None));
        }

        private void WaitAccountFightOrRegen()
        {
            do
            {
                Account.Wait(1);
            } while (Account.State != Status.None);
        }

        /// <summary>
        /// Clear the current action stack.
        /// </summary>
        public void ClearStack()
        {
            if (ActionsStack != null)
                ActionsStack.Clear();
        }

        /// <summary>
        /// Parse the path's file.
        /// </summary>
        public void ParsePath()
        {
            //Thread t = new Thread(() =>
            //{
                //TODO: Fix the parser
                conditions = new List<PathCondition>();
                ActionsStack = new List<Action>();
                ListActions = new List<string>();
                CurrentAction = String.Empty;
                var listActionsPath = m_content.Where(elem => !String.IsNullOrEmpty(elem) && !elem.StartsWith("@"));
                foreach (string line in listActionsPath)
                {
                    ListActions.Add(line);
                }
                WorkingActionsQueue = new Queue<string>(ListActions);
                DequeueAction();
            //});
            //t.Start();
        }

        public void DequeueAction()
        {
            if (WorkingActionsQueue.Count() > 0)
            {
                CurrentAction = WorkingActionsQueue.Dequeue();
                TreatAction();
            }
            else if (Account.MyGroup != null)
            {
                if (Account.MyGroup.GetMaster().Config.RelaunchPath)
                    ParsePath();
            }
            else if(Account.Config.RelaunchPath)
            {
                ParsePath();
            }
        }

        private void TreatAction()
        {
            if (CurrentAction.Contains("+Condition "))
            {
                ParseCondition(CurrentAction);
                DequeueAction();
            }
            else if (flags.Any(flag => CurrentAction.Contains(flag)))
            {
                flag = flags.ElementAt(flags.IndexOf(CurrentAction));
                DequeueAction();
            }
            else if (Endflags.Any(Endflag => CurrentAction.Contains(Endflag)))
            {
                conditions.Clear();
                flag = String.Empty;
                DequeueAction();
            }
            else if (CheckConditions(false))
            {
                Current_Map = Account.MapData.Pos;
                AnalyseLine();
            }
        }

        /// <summary>
        /// Pull the last action from the stack and perform it.
        /// </summary>
        public void PerformActionsStack()
        {
            while (ActionsStack.Count() > 0)
            {
                Current_Action = ActionsStack[0];
                Current_Action.PerformAction();
                ActionsStack.Remove(Current_Action);
            }
            DequeueAction();
        }
        #endregion

        #region Private methods

        /// <summary>
        /// Parse the line with the current pos.
        /// </summary>
        private void AnalyseLine()
        {
            if (CurrentAction.Contains("@"))
                return;
            if (CheckConditions(true) && flag != String.Empty)
            {
                ParseAction(CurrentAction);
                PerformFlag();
            }
        }

        /// <summary>
        /// Parse a condition's line
        /// </summary>
        private void ParseCondition(string line)
        {
            line = line.Remove(0, 10);
            line = line.Trim();
            foreach (char oper in operateurs)
            {
                if (line.IndexOf(oper) != -1)
                {
                    PathConditionEnum condition = PathConditionEnum.Null;
                    string b = line.Substring(0, line.IndexOf(oper));
                    switch (b)
                    {
                        case "None":
                            condition = PathConditionEnum.Null;
                            break;
                        case "LastMap":
                            condition = PathConditionEnum.LastMapId;
                            break;
                        case "Level":
                            condition = PathConditionEnum.Level;
                            break;
                        case "Pods":
                            condition = PathConditionEnum.Pods;
                            break;
                        case "%Pods":
                            condition = PathConditionEnum.PodsPercent;
                            break;
                        case "Alive":
                            condition = PathConditionEnum.Alive;
                            break;
                    }
                    line = line.Remove(0, line.IndexOf(oper) + 1);
                    PathCondition c = new PathCondition(condition, line, oper, Account);
                    conditions.Add(c);
                    return;
                }
            }
        }

        /// <summary>
        /// Parse an action's line
        /// </summary>
        private void ParseAction(string line)
        {
            if (line.IndexOf(':') != -1)
            {
                line = line.Remove(0, line.IndexOf(':') + 1);
            }
            line = line.Trim();
            foreach (string s in Actions)
            {
                int index = line.IndexOf(s);
                if (index != -1 && line.IndexOf('+') != -1)
                {
                    line = line.Remove(0, s.Length);
                    // on supprime de la ligne la string d'action
                    Action a = new Action(s, line.Substring(0, line.IndexOf('+')), Account);
                    ActionsStack.Add(a);
                    line = line.Remove(0, line.IndexOf('+') + 1);
                    ParseAction(line);
                    return;
                }
                else if (index != -1)
                {
                    line = line.Remove(0, s.Length);
                    // on supprime de la ligne la string d'action
                    Action a = new Action(s, line.Substring(0, line.IndexOf(')')), Account);
                    ActionsStack.Add(a);
                    return;
                }

            }

        }

        /// <summary>
        /// Check if all the conditions in the conditions are respected or not.
        /// </summary>
        private bool CheckConditions(bool analysed)
        {
            foreach (PathCondition c in conditions)
            {
                if (c.CheckCondition() == false)
                {
                    if (analysed)
                        Account.Log(new BotTextInformation("Path : Condition not met"), 5);
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Check if the line is with the same number of '-' char as the position.
        /// </summary>
        private bool CheckMinusNumber(string line)
        {
            if (!line.Contains(','))
                return true;
            line = line.Remove(line.IndexOf(':'));
            int n = line.ToList().FindAll(c => c == '-').Count;
            int comp = Account.MapData.Pos.ToList().FindAll(c => c == '-').Count;
            return n == comp;
        }

        /// <summary>
        /// Alert the user that we are lost.
        /// </summary>
        private void Lost()
        {
            Account.Log(new ErrorTextInformation("Aucune action disponible dans le trajet, le bot est perdu."), 0);
            StopPath();
        }
        #endregion


    }
}
