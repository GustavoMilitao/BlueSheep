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
    using MageBot.Protocol.Types.Game.Data.Items;


    public class ExchangeShopStockMovementUpdatedMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5909;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ObjectItemToSell m_objectInfo;
        
        public virtual ObjectItemToSell ObjectInfo
        {
            get
            {
                return m_objectInfo;
            }
            set
            {
                m_objectInfo = value;
            }
        }
        
        public ExchangeShopStockMovementUpdatedMessage(ObjectItemToSell objectInfo)
        {
            m_objectInfo = objectInfo;
        }
        
        public ExchangeShopStockMovementUpdatedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_objectInfo.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_objectInfo = new ObjectItemToSell();
            m_objectInfo.Deserialize(reader);
        }
    }
}
