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
    public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6021;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_allow;
        
        public virtual bool Allow
        {
            get
            {
                return m_allow;
            }
            set
            {
                m_allow = value;
            }
        }
        
        public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage(bool allow)
        {
            m_allow = allow;
        }
        
        public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_allow);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_allow = reader.ReadBoolean();
        }
    }
}
