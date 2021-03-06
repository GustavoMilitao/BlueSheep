﻿using Util.Util.I18n.Strings;
using Util.Util.Text.Log;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MageBot.Interface
{
    public partial class PathChoiceForm : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Bot's path choose form.
        /// </summary>

        #region Fields
        private AccountUC accUserControl;
        #endregion

        #region Constructors
        public PathChoiceForm(AccountUC account)
        {
            InitializeComponent();
            accUserControl = account;
            Text = Strings.PathManager;
            DelBt.Text = Strings.Delete;
            LoadBt.Text = Strings.Load;
            AddBt.Text = Strings.Add;
            FilesList.Columns[0].Text = Strings.Name;
            FilesList.Columns[4].Text = Strings.Author;
        }
        #endregion

        #region Interface methods
        private void PathChoiceForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string combinedPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MageBot", "Paths", openFileDialog1.SafeFileName);
                if (!File.Exists(combinedPath))
                {
                    File.Copy(openFileDialog1.FileName, combinedPath);
                    FilesList.Items.Clear();
                    Init();
                }
                else
                {
                    MessageBox.Show("The path has already been added!");
                }
            }
        }

        private void LoadBt_Click(object sender, EventArgs e)
        {
            LaunchPath(null, null);
        }

        private void DelBt_Click(object sender, EventArgs e)
        {
            if (FilesList.SelectedItems.Count > 0)
            {
                string path = FilesList.SelectedItems[0].SubItems[5].Text;
                File.Delete(path);
                FilesList.Items.Remove(FilesList.SelectedItems[0]);
            }
        }
        #endregion

        #region Private methods
        private void Init()
        {
            string combinedPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MageBot", "Paths");
            openFileDialog1.InitialDirectory = combinedPath;
            DirectoryInfo di = new DirectoryInfo(combinedPath);
            if (di.GetFiles().Count() == 0)
            {
                MessageBox.Show("No path found, please download on the forum or create your own :)");
            }
            else
            {
                foreach (FileInfo file in di.GetFiles())
                {
                    LoadPath(file);
                }
            }
        }

        private void LoadPath(FileInfo fi)
        {
            StreamReader sr = new StreamReader(fi.FullName);
            string line = null;
            string[] infos = new string[6];
            for (int i = 0; i < 5; i++)
            {
                line = sr.ReadLine();
                if (line == null || line.Length < 5)
                {
                    MessageBox.Show("Malformated header. Check your path's syntax. " + fi.FullName);
                    return;
                }
                line.Replace(" ", "");
                switch (i)
                {
                    case 0:
                        infos[i] = line.Remove(0, 5).Trim();
                        //enleve @NAME
                        break;
                    case 1:
                        infos[i] = line.Remove(0, 9).Trim();
                        //@LOCATION
                        break;
                    case 2:
                        infos[i] = line.Remove(0, 5).Trim();
                        //enleve @TYPE
                        break;
                    case 3:
                        infos[i] = line.Remove(0, 8).Trim();
                        //enleve @VERSION
                        break;
                    case 4:
                        infos[i] = line.Remove(0, 7).Trim();
                        //enleve @AUTHOR
                        break;
                }
            }
            infos[5] = fi.FullName;
            sr.Close();
            FilesList.Items.Add(infos[0]).SubItems.AddRange(new string[] {
        infos[1],
        infos[2],
        infos[3],
        infos[4],
        infos[5]
    });
        }


        private void LaunchPath(object sender, EventArgs e)
        {
            if (FilesList.SelectedItems.Count > 0 && accUserControl != null)
            {
                accUserControl.Account.Path = new MageBot.Core.Path.PathManager(accUserControl.Account, FilesList.SelectedItems[0].SubItems[5].Text, FilesList.SelectedItems[0].SubItems[0].Text);
                accUserControl.Account.Config.PreLoadedPath = accUserControl.Account.Path.Path;
                accUserControl.Account.Config.PreLoadedPathName = accUserControl.Account.Path.PathName;
                accUserControl.Account.Log(new BotTextInformation("Path loaded : " + FilesList.SelectedItems[0].Text), 0);
                accUserControl.Account.Path.Path = FilesList.SelectedItems[0].Text;
                accUserControl.PathDownBt.Text = accUserControl.Account.Path.PathName;
                if (accUserControl.Account.Fight == null)
                {
                    accUserControl.Account.Log(new ErrorTextInformation("WARNING : You haven't any AI loaded :p"), 0);
                }
                Close();
            }
        }
        #endregion



    }
}
