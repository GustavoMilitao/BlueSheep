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
    public class ExchangeBuyMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5774;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_objectToBuyId;
        
        public virtual uint ObjectToBuyId
        {
            get
            {
                return m_objectToBuyId;
            }
            set
            {
                m_objectToBuyId = value;
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
        
        public ExchangeBuyMessage(uint objectToBuyId, uint quantity)
        {
            m_objectToBuyId = objectToBuyId;
            m_quantity = quantity;
        }
        
        public ExchangeBuyMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_objectToBuyId);
            writer.WriteVarInt(m_quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_objectToBuyId = reader.ReadVarUhInt();
            m_quantity = reader.ReadVarUhInt();
        }
    }
}
