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
    public class ExchangeCrafterJobLevelupMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6598;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
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
        
        public ExchangeCrafterJobLevelupMessage(sbyte crafterJobLevel)
        {
            m_crafterJobLevel = crafterJobLevel;
        }
        
        public ExchangeCrafterJobLevelupMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSByte(m_crafterJobLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_crafterJobLevel = reader.ReadSByte();
        }
    }
}
