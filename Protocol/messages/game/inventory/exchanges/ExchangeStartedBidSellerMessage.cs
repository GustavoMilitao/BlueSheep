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
    using System.Collections.Generic;


    public class ExchangeStartedBidSellerMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5905;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private SellerBuyerDescriptor m_sellerDescriptor;
        
        public virtual SellerBuyerDescriptor SellerDescriptor
        {
            get
            {
                return m_sellerDescriptor;
            }
            set
            {
                m_sellerDescriptor = value;
            }
        }
        
        private List<ObjectItemToSellInBid> m_objectsInfos;
        
        public virtual List<ObjectItemToSellInBid> ObjectsInfos
        {
            get
            {
                return m_objectsInfos;
            }
            set
            {
                m_objectsInfos = value;
            }
        }
        
        public ExchangeStartedBidSellerMessage(SellerBuyerDescriptor sellerDescriptor, List<ObjectItemToSellInBid> objectsInfos)
        {
            m_sellerDescriptor = sellerDescriptor;
            m_objectsInfos = objectsInfos;
        }
        
        public ExchangeStartedBidSellerMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_sellerDescriptor.Serialize(writer);
            writer.WriteShort(((short)(m_objectsInfos.Count)));
            int objectsInfosIndex;
            for (objectsInfosIndex = 0; (objectsInfosIndex < m_objectsInfos.Count); objectsInfosIndex = (objectsInfosIndex + 1))
            {
                ObjectItemToSellInBid objectToSend = m_objectsInfos[objectsInfosIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_sellerDescriptor = new SellerBuyerDescriptor();
            m_sellerDescriptor.Deserialize(reader);
            int objectsInfosCount = reader.ReadUShort();
            int objectsInfosIndex;
            m_objectsInfos = new System.Collections.Generic.List<ObjectItemToSellInBid>();
            for (objectsInfosIndex = 0; (objectsInfosIndex < objectsInfosCount); objectsInfosIndex = (objectsInfosIndex + 1))
            {
                ObjectItemToSellInBid objectToAdd = new ObjectItemToSellInBid();
                objectToAdd.Deserialize(reader);
                m_objectsInfos.Add(objectToAdd);
            }
        }
    }
}
