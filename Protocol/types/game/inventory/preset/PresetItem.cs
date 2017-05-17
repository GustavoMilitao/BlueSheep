//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Inventory.Preset
{
    using MageBot.Protocol.Types;


    public class PresetItem : NetworkType
    {
        
        protected override int ProtocolId { get; set; } = 354;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_position;
        
        public virtual sbyte Position
        {
            get
            {
                return m_position;
            }
            set
            {
                m_position = value;
            }
        }
        
        private ushort m_objGid;
        
        public virtual ushort ObjGid
        {
            get
            {
                return m_objGid;
            }
            set
            {
                m_objGid = value;
            }
        }
        
        private uint m_objUid;
        
        public virtual uint ObjUid
        {
            get
            {
                return m_objUid;
            }
            set
            {
                m_objUid = value;
            }
        }
        
        public PresetItem(sbyte position, ushort objGid, uint objUid)
        {
            m_position = position;
            m_objGid = objGid;
            m_objUid = objUid;
        }
        
        public PresetItem()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSByte(m_position);
            writer.WriteVarShort(m_objGid);
            writer.WriteVarInt(m_objUid);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_position = reader.ReadSByte();
            m_objGid = reader.ReadVarUhShort();
            m_objUid = reader.ReadVarUhInt();
        }
    }
}
