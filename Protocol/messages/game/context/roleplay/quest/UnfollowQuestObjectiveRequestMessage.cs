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
    public class UnfollowQuestObjectiveRequestMessage : Message
    {
        
        public override int ProtocolId { get; } = 6723;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_questId;
        
        public virtual ushort QuestId
        {
            get
            {
                return m_questId;
            }
            set
            {
                m_questId = value;
            }
        }
        
        private short m_objectiveId;
        
        public virtual short ObjectiveId
        {
            get
            {
                return m_objectiveId;
            }
            set
            {
                m_objectiveId = value;
            }
        }
        
        public UnfollowQuestObjectiveRequestMessage(ushort questId, short objectiveId)
        {
            m_questId = questId;
            m_objectiveId = objectiveId;
        }
        
        public UnfollowQuestObjectiveRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_questId);
            writer.WriteShort(m_objectiveId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_questId = reader.ReadVarUhShort();
            m_objectiveId = reader.ReadShort();
        }
    }
}
