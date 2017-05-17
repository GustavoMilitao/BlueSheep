//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Prism
{
    public class PrismSettingsRequestMessage : Message
    {
        
        public override int ProtocolId { get; } = 6437;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_subAreaId;
        
        public virtual ushort SubAreaId
        {
            get
            {
                return m_subAreaId;
            }
            set
            {
                m_subAreaId = value;
            }
        }
        
        private byte m_startDefenseTime;
        
        public virtual byte StartDefenseTime
        {
            get
            {
                return m_startDefenseTime;
            }
            set
            {
                m_startDefenseTime = value;
            }
        }
        
        public PrismSettingsRequestMessage(ushort subAreaId, byte startDefenseTime)
        {
            m_subAreaId = subAreaId;
            m_startDefenseTime = startDefenseTime;
        }
        
        public PrismSettingsRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_subAreaId);
            writer.WriteByte(m_startDefenseTime);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_subAreaId = reader.ReadVarUhShort();
            m_startDefenseTime = reader.ReadByte();
        }
    }
}
