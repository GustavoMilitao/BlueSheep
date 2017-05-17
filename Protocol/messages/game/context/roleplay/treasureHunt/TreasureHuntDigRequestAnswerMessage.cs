//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    public class TreasureHuntDigRequestAnswerMessage : Message
    {
        
        public override int ProtocolId { get; } = 6484;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_questType;
        
        public virtual byte QuestType
        {
            get
            {
                return m_questType;
            }
            set
            {
                m_questType = value;
            }
        }
        
        private byte m_result;
        
        public virtual byte Result
        {
            get
            {
                return m_result;
            }
            set
            {
                m_result = value;
            }
        }
        
        public TreasureHuntDigRequestAnswerMessage(byte questType, byte result)
        {
            m_questType = questType;
            m_result = result;
        }
        
        public TreasureHuntDigRequestAnswerMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_questType);
            writer.WriteByte(m_result);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_questType = reader.ReadByte();
            m_result = reader.ReadByte();
        }
    }
}
