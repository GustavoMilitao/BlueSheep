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
    using MageBot.Protocol.Types.Game.Data.Items;


    public class StorageObjectUpdateMessage : Message
    {
        
        public override int ProtocolId { get; } = 5647;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ObjectItem m_object;
        
        public virtual ObjectItem Object
        {
            get
            {
                return m_object;
            }
            set
            {
                m_object = value;
            }
        }
        
        public StorageObjectUpdateMessage(ObjectItem @object)
        {
            m_object = @object;
        }
        
        public StorageObjectUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_object.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_object = new ObjectItem();
            m_object.Deserialize(reader);
        }
    }
}
