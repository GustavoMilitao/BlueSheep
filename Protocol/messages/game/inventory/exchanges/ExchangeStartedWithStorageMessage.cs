//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Inventory.Exchanges
{


    public class ExchangeStartedWithStorageMessage : ExchangeStartedMessage
    {
        
        public const int ProtocolId = 6236;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_storageMaxSlot;
        
        public virtual uint StorageMaxSlot
        {
            get
            {
                return m_storageMaxSlot;
            }
            set
            {
                m_storageMaxSlot = value;
            }
        }
        
        public ExchangeStartedWithStorageMessage(uint storageMaxSlot)
        {
            m_storageMaxSlot = storageMaxSlot;
        }
        
        public ExchangeStartedWithStorageMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt(m_storageMaxSlot);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_storageMaxSlot = reader.ReadVarUhInt();
        }
    }
}