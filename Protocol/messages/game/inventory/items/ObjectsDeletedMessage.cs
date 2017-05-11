//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Inventory.Items
{
    using System.Collections.Generic;
    using BlueSheep.Protocol;


    public class ObjectsDeletedMessage : Message
    {
        
        public const int ProtocolId = 6034;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt32> m_objectUID;
        
        public virtual List<System.UInt32> ObjectUID
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
        
        public ObjectsDeletedMessage(List<System.UInt32> objectUID)
        {
            m_objectUID = objectUID;
        }
        
        public ObjectsDeletedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_objectUID.Count)));
            int objectUIDIndex;
            for (objectUIDIndex = 0; (objectUIDIndex < m_objectUID.Count); objectUIDIndex = (objectUIDIndex + 1))
            {
                writer.WriteVarInt(m_objectUID[objectUIDIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int objectUIDCount = reader.ReadUShort();
            int objectUIDIndex;
            m_objectUID = new System.Collections.Generic.List<uint>();
            for (objectUIDIndex = 0; (objectUIDIndex < objectUIDCount); objectUIDIndex = (objectUIDIndex + 1))
            {
                m_objectUID.Add(reader.ReadVarUhInt());
            }
        }
    }
}