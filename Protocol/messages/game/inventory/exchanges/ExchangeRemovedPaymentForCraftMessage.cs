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
    public class ExchangeRemovedPaymentForCraftMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6031;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_onlySuccess;
        
        public virtual bool OnlySuccess
        {
            get
            {
                return m_onlySuccess;
            }
            set
            {
                m_onlySuccess = value;
            }
        }
        
        private uint m_objectUID;
        
        public virtual uint ObjectUID
        {
            get
            {
                return m_objectUID;
            }
            set
            {
                m_objectUID = value;
            }
        }
        
        public ExchangeRemovedPaymentForCraftMessage(bool onlySuccess, uint objectUID)
        {
            m_onlySuccess = onlySuccess;
            m_objectUID = objectUID;
        }
        
        public ExchangeRemovedPaymentForCraftMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_onlySuccess);
            writer.WriteVarInt(m_objectUID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_onlySuccess = reader.ReadBoolean();
            m_objectUID = reader.ReadVarUhInt();
        }
    }
}
