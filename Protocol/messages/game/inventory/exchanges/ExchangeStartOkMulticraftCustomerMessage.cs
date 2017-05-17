//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Inventory.Exchanges
{
    public class ExchangeStartOkMulticraftCustomerMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5817;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_skillId;
        
        public virtual uint SkillId
        {
            get
            {
                return m_skillId;
            }
            set
            {
                m_skillId = value;
            }
        }
        
        private sbyte m_crafterJobLevel;
        
        public virtual sbyte CrafterJobLevel
        {
            get
            {
                return m_crafterJobLevel;
            }
            set
            {
                m_crafterJobLevel = value;
            }
        }
        
        public ExchangeStartOkMulticraftCustomerMessage(uint skillId, sbyte crafterJobLevel)
        {
            m_skillId = skillId;
            m_crafterJobLevel = crafterJobLevel;
        }
        
        public ExchangeStartOkMulticraftCustomerMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_skillId);
            writer.WriteSByte(m_crafterJobLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_skillId = reader.ReadVarUhInt();
            m_crafterJobLevel = reader.ReadSByte();
        }
    }
}
