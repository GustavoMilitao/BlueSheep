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
    public class LivingObjectChangeSkinRequestMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5725;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_livingUID;
        
        public virtual uint LivingUID
        {
            get
            {
                return m_livingUID;
            }
            set
            {
                m_livingUID = value;
            }
        }
        
        private sbyte m_livingPosition;
        
        public virtual sbyte LivingPosition
        {
            get
            {
                return m_livingPosition;
            }
            set
            {
                m_livingPosition = value;
            }
        }
        
        private uint m_skinId;
        
        public virtual uint SkinId
        {
            get
            {
                return m_skinId;
            }
            set
            {
                m_skinId = value;
            }
        }
        
        public LivingObjectChangeSkinRequestMessage(uint livingUID, sbyte livingPosition, uint skinId)
        {
            m_livingUID = livingUID;
            m_livingPosition = livingPosition;
            m_skinId = skinId;
        }
        
        public LivingObjectChangeSkinRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_livingUID);
            writer.WriteSByte(m_livingPosition);
            writer.WriteVarInt(m_skinId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_livingUID = reader.ReadVarUhInt();
            m_livingPosition = reader.ReadSByte();
            m_skinId = reader.ReadVarUhInt();
        }
    }
}
