//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Quest
{
    using MageBot.Protocol.Types.Game.Context.Roleplay.Quest;
    using System.Collections.Generic;
    using MageBot.Protocol.Types;


    public class QuestListMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5626;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_finishedQuestsIds;
        
        public virtual List<System.UInt16> FinishedQuestsIds
        {
            get
            {
                return m_finishedQuestsIds;
            }
            set
            {
                m_finishedQuestsIds = value;
            }
        }
        
        private List<System.UInt16> m_finishedQuestsCounts;
        
        public virtual List<System.UInt16> FinishedQuestsCounts
        {
            get
            {
                return m_finishedQuestsCounts;
            }
            set
            {
                m_finishedQuestsCounts = value;
            }
        }
        
        private List<QuestActiveInformations> m_activeQuests;
        
        public virtual List<QuestActiveInformations> ActiveQuests
        {
            get
            {
                return m_activeQuests;
            }
            set
            {
                m_activeQuests = value;
            }
        }
        
        private List<System.UInt16> m_reinitDoneQuestsIds;
        
        public virtual List<System.UInt16> ReinitDoneQuestsIds
        {
            get
            {
                return m_reinitDoneQuestsIds;
            }
            set
            {
                m_reinitDoneQuestsIds = value;
            }
        }
        
        public QuestListMessage(List<System.UInt16> finishedQuestsIds, List<System.UInt16> finishedQuestsCounts, List<QuestActiveInformations> activeQuests, List<System.UInt16> reinitDoneQuestsIds)
        {
            m_finishedQuestsIds = finishedQuestsIds;
            m_finishedQuestsCounts = finishedQuestsCounts;
            m_activeQuests = activeQuests;
            m_reinitDoneQuestsIds = reinitDoneQuestsIds;
        }
        
        public QuestListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_finishedQuestsIds.Count)));
            int finishedQuestsIdsIndex;
            for (finishedQuestsIdsIndex = 0; (finishedQuestsIdsIndex < m_finishedQuestsIds.Count); finishedQuestsIdsIndex = (finishedQuestsIdsIndex + 1))
            {
                writer.WriteVarShort(m_finishedQuestsIds[finishedQuestsIdsIndex]);
            }
            writer.WriteShort(((short)(m_finishedQuestsCounts.Count)));
            int finishedQuestsCountsIndex;
            for (finishedQuestsCountsIndex = 0; (finishedQuestsCountsIndex < m_finishedQuestsCounts.Count); finishedQuestsCountsIndex = (finishedQuestsCountsIndex + 1))
            {
                writer.WriteVarShort(m_finishedQuestsCounts[finishedQuestsCountsIndex]);
            }
            writer.WriteShort(((short)(m_activeQuests.Count)));
            int activeQuestsIndex;
            for (activeQuestsIndex = 0; (activeQuestsIndex < m_activeQuests.Count); activeQuestsIndex = (activeQuestsIndex + 1))
            {
                QuestActiveInformations objectToSend = m_activeQuests[activeQuestsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_reinitDoneQuestsIds.Count)));
            int reinitDoneQuestsIdsIndex;
            for (reinitDoneQuestsIdsIndex = 0; (reinitDoneQuestsIdsIndex < m_reinitDoneQuestsIds.Count); reinitDoneQuestsIdsIndex = (reinitDoneQuestsIdsIndex + 1))
            {
                writer.WriteVarShort(m_reinitDoneQuestsIds[reinitDoneQuestsIdsIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int finishedQuestsIdsCount = reader.ReadUShort();
            int finishedQuestsIdsIndex;
            m_finishedQuestsIds = new System.Collections.Generic.List<ushort>();
            for (finishedQuestsIdsIndex = 0; (finishedQuestsIdsIndex < finishedQuestsIdsCount); finishedQuestsIdsIndex = (finishedQuestsIdsIndex + 1))
            {
                m_finishedQuestsIds.Add(reader.ReadVarUhShort());
            }
            int finishedQuestsCountsCount = reader.ReadUShort();
            int finishedQuestsCountsIndex;
            m_finishedQuestsCounts = new System.Collections.Generic.List<ushort>();
            for (finishedQuestsCountsIndex = 0; (finishedQuestsCountsIndex < finishedQuestsCountsCount); finishedQuestsCountsIndex = (finishedQuestsCountsIndex + 1))
            {
                m_finishedQuestsCounts.Add(reader.ReadVarUhShort());
            }
            int activeQuestsCount = reader.ReadUShort();
            int activeQuestsIndex;
            m_activeQuests = new System.Collections.Generic.List<QuestActiveInformations>();
            for (activeQuestsIndex = 0; (activeQuestsIndex < activeQuestsCount); activeQuestsIndex = (activeQuestsIndex + 1))
            {
                QuestActiveInformations objectToAdd = ProtocolTypeManager.GetInstance<QuestActiveInformations>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_activeQuests.Add(objectToAdd);
            }
            int reinitDoneQuestsIdsCount = reader.ReadUShort();
            int reinitDoneQuestsIdsIndex;
            m_reinitDoneQuestsIds = new System.Collections.Generic.List<ushort>();
            for (reinitDoneQuestsIdsIndex = 0; (reinitDoneQuestsIdsIndex < reinitDoneQuestsIdsCount); reinitDoneQuestsIdsIndex = (reinitDoneQuestsIdsIndex + 1))
            {
                m_reinitDoneQuestsIds.Add(reader.ReadVarUhShort());
            }
        }
    }
}
