//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Inventory.Items
{
    public class ExchangeMultiCraftCrafterCanUseHisRessourcesMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6020;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_allowed;
        
        public virtual bool Allowed
        {
            get
            {
                return m_allowed;
            }
            set
            {
                m_allowed = value;
            }
        }
        
        public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage(bool allowed)
        {
            m_allowed = allowed;
        }
        
        public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_allowed);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_allowed = reader.ReadBoolean();
        }
    }
}
