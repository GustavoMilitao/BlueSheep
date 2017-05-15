﻿using BlueSheep.Util.IO;
using BlueSheep.Protocol.Messages.Game.Context.Roleplay.Job;
using BlueSheep.Protocol.Types.Game.Context.Roleplay.Job;
using BlueSheep.Protocol.Types.Game.Interactive.Skill;
using BlueSheep.Protocol.Messages;
using System.Collections.Generic;

namespace BlueSheep.Engine.Handlers.Job
{
    class JobHandler
    {
         #region Public methods
        [MessageHandler(typeof(JobDescriptionMessage))]
        public static void JobDescriptionMessageTreatment(Message message,  Account account)
        {
            JobDescriptionMessage msg = (JobDescriptionMessage)message;

            using (BigEndianReader reader = new BigEndianReader(packetDatas))
            {
                msg.Deserialize(reader);
            }

            foreach (JobDescription job in msg.JobsDescription)
            {
                List<int> skills = new List<int>();
                foreach (SkillActionDescription s in job.Skills)
                {
                    skills.Add(s.SkillId);
                }
                Core.Job.Job j = new Core.Job.Job(job.JobId, skills, account);
                account.Jobs.Add(j);
            }
        }

        [MessageHandler(typeof(JobExperienceMultiUpdateMessage))]
        public static void JobExperienceMultiUpdateMessageTreatment(Message message,  Account account)
        {
            JobExperienceMultiUpdateMessage msg = (JobExperienceMultiUpdateMessage)message;

            using (BigEndianReader reader = new BigEndianReader(packetDatas))
            {
                msg.Deserialize(reader);
            }
            foreach (JobExperience i in msg.ExperiencesUpdate)
            {
                foreach (Core.Job.Job j in account.Jobs)
                {
                    if (i.JobId == j.Id)
                    {
                        j.Level = i.JobLevel;
                        j.XP = (int)i.JobXP;
                        j.XpLevelFloor =(int)i.JobXpLevelFloor;
                        j.XpNextLevelFloor = (int)i.JobXpNextLevelFloor;
                        break;
                    }
                }
            }
            //account.ActualizeJobs();
            // TODO Militão: Populate the new interface
        }

        [MessageHandler(typeof(JobExperienceUpdateMessage))]
        public static void JobExperienceUpdateMessageTreatment(Message message,  Account account)
        {
            JobExperienceUpdateMessage msg = (JobExperienceUpdateMessage)message;

            using (BigEndianReader reader = new BigEndianReader(packetDatas))
            {
                msg.Deserialize(reader);
            }
            JobExperience i = msg.ExperiencesUpdate;
            foreach (Core.Job.Job j in account.Jobs)
            {
                if (i.JobId == j.Id)
                {
                    j.Level = i.JobLevel;
                    j.XP = (int)i.JobXP;
                    j.XpLevelFloor = (int)i.JobXpLevelFloor;
                    j.XpNextLevelFloor = (int)i.JobXpNextLevelFloor;
                    break;
                }
            }
            //foreach (JobUC j in account.JobsUC)
            //    j.UpdateJob();
            // TODO Militão: Populate the new interface

        }

        #endregion
    }
}
