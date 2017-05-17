//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Inventory.Items
{
    public class SymbioticObjectAssociateRequestMessage : Message
    {
        
        public override int ProtocolId { get; } = 6522;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_symbioteUID;
        
        public virtual uint SymbioteUID
        {
            get
            {
                return m_symbioteUID;
            }
            set
            {
                m_symbioteUID = value;
            }
        }
        
        private sbyte m_symbiotePos;
        
        public virtual sbyte SymbiotePos
        {
            get
            {
                return m_symbiotePos;
            }
            set
            {
                m_symbiotePos = value;
            }
        }
        
        private uint m_hostUID;
        
        public virtual uint HostUID
        {
            get
            {
                return m_hostUID;
            }
            set
            {
                m_hostUID = value;
            }
        }
        
        private sbyte m_hostPos;
        
        public virtual sbyte HostPos
        {
            get
            {
                return m_hostPos;
            }
            set
            {
                m_hostPos = value;
            }
        }
        
        public SymbioticObjectAssociateRequestMessage(uint symbioteUID, sbyte symbiotePos, uint hostUID, sbyte hostPos)
        {
            m_symbioteUID = symbioteUID;
            m_symbiotePos = symbiotePos;
            m_hostUID = hostUID;
            m_hostPos = hostPos;
        }
        
        public SymbioticObjectAssociateRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_symbioteUID);
            writer.WriteSByte(m_symbiotePos);
            writer.WriteVarInt(m_hostUID);
            writer.WriteSByte(m_hostPos);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_symbioteUID = reader.ReadVarUhInt();
            m_symbiotePos = reader.ReadSByte();
            m_hostUID = reader.ReadVarUhInt();
            m_hostPos = reader.ReadSByte();
        }
    }
}
