//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Inventory.Storage
{
    using System.Collections.Generic;


    public class StorageObjectsRemoveMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6035;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt32> m_objectUIDList;
        
        public virtual List<System.UInt32> ObjectUIDList
        {
            get
            {
                return m_objectUIDList;
            }
            set
            {
                m_objectUIDList = value;
            }
        }
        
        public StorageObjectsRemoveMessage(List<System.UInt32> objectUIDList)
        {
            m_objectUIDList = objectUIDList;
        }
        
        public StorageObjectsRemoveMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_objectUIDList.Count)));
            int objectUIDListIndex;
            for (objectUIDListIndex = 0; (objectUIDListIndex < m_objectUIDList.Count); objectUIDListIndex = (objectUIDListIndex + 1))
            {
                writer.WriteVarInt(m_objectUIDList[objectUIDListIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int objectUIDListCount = reader.ReadUShort();
            int objectUIDListIndex;
            m_objectUIDList = new System.Collections.Generic.List<uint>();
            for (objectUIDListIndex = 0; (objectUIDListIndex < objectUIDListCount); objectUIDListIndex = (objectUIDListIndex + 1))
            {
                m_objectUIDList.Add(reader.ReadVarUhInt());
            }
        }
    }
}
