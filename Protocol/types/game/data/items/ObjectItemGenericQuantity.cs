//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Data.Items
{


    public class ObjectItemGenericQuantity : Item
    {
        
        protected override int ProtocolId { get; set; } = 483;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_objectGID;
        
        public virtual ushort ObjectGID
        {
            get
            {
                return m_objectGID;
            }
            set
            {
                m_objectGID = value;
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
        
        public ObjectItemGenericQuantity(ushort objectGID, uint quantity)
        {
            m_objectGID = objectGID;
            m_quantity = quantity;
        }
        
        public ObjectItemGenericQuantity()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort(m_objectGID);
            writer.WriteVarInt(m_quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_objectGID = reader.ReadVarUhShort();
            m_quantity = reader.ReadVarUhInt();
        }
    }
}
