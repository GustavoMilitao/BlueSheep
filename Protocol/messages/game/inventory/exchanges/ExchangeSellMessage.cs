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
    public class ExchangeSellMessage : Message
    {
        
        public override int ProtocolId { get; } = 5778;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_objectToSellId;
        
        public virtual uint ObjectToSellId
        {
            get
            {
                return m_objectToSellId;
            }
            set
            {
                m_objectToSellId = value;
            }
        }
        
        private uint m_quantity;
        
        public virtual uint Quantity
        {
            get
            {
                return m_quantity;
            }
            set
            {
                m_quantity = value;
            }
        }
        
        public ExchangeSellMessage(uint objectToSellId, uint quantity)
        {
            m_objectToSellId = objectToSellId;
            m_quantity = quantity;
        }
        
        public ExchangeSellMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_objectToSellId);
            writer.WriteVarInt(m_quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_objectToSellId = reader.ReadVarUhInt();
            m_quantity = reader.ReadVarUhInt();
        }
    }
}
