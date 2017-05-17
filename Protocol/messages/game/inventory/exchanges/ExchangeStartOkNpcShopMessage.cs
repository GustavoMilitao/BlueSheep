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


    public class ExchangeStartOkNpcShopMessage : Message
    {
        
        public override int ProtocolId { get; } = 5761;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ObjectItemToSellInNpcShop> m_objectsInfos;
        
        public virtual List<ObjectItemToSellInNpcShop> ObjectsInfos
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
        
        private double m_npcSellerId;
        
        public virtual double NpcSellerId
        {
            get
            {
                return m_npcSellerId;
            }
            set
            {
                m_npcSellerId = value;
            }
        }
        
        private ushort m_tokenId;
        
        public virtual ushort TokenId
        {
            get
            {
                return m_tokenId;
            }
            set
            {
                m_tokenId = value;
            }
        }
        
        public ExchangeStartOkNpcShopMessage(List<ObjectItemToSellInNpcShop> objectsInfos, double npcSellerId, ushort tokenId)
        {
            m_objectsInfos = objectsInfos;
            m_npcSellerId = npcSellerId;
            m_tokenId = tokenId;
        }
        
        public ExchangeStartOkNpcShopMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_objectsInfos.Count)));
            int objectsInfosIndex;
            for (objectsInfosIndex = 0; (objectsInfosIndex < m_objectsInfos.Count); objectsInfosIndex = (objectsInfosIndex + 1))
            {
                ObjectItemToSellInNpcShop objectToSend = m_objectsInfos[objectsInfosIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteDouble(m_npcSellerId);
            writer.WriteVarShort(m_tokenId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int objectsInfosCount = reader.ReadUShort();
            int objectsInfosIndex;
            m_objectsInfos = new System.Collections.Generic.List<ObjectItemToSellInNpcShop>();
            for (objectsInfosIndex = 0; (objectsInfosIndex < objectsInfosCount); objectsInfosIndex = (objectsInfosIndex + 1))
            {
                ObjectItemToSellInNpcShop objectToAdd = new ObjectItemToSellInNpcShop();
                objectToAdd.Deserialize(reader);
                m_objectsInfos.Add(objectToAdd);
            }
            m_npcSellerId = reader.ReadDouble();
            m_tokenId = reader.ReadVarUhShort();
        }
    }
}
