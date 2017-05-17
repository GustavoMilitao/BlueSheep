//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Report
{
    public class CharacterReportMessage : Message
    {
        
        public override int ProtocolId { get; } = 6079;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_reportedId;
        
        public virtual ulong ReportedId
        {
            get
            {
                return m_reportedId;
            }
            set
            {
                m_reportedId = value;
            }
        }
        
        private byte m_reason;
        
        public virtual byte Reason
        {
            get
            {
                return m_reason;
            }
            set
            {
                m_reason = value;
            }
        }
        
        public CharacterReportMessage(ulong reportedId, byte reason)
        {
            m_reportedId = reportedId;
            m_reason = reason;
        }
        
        public CharacterReportMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_reportedId);
            writer.WriteByte(m_reason);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_reportedId = reader.ReadVarUhLong();
            m_reason = reader.ReadByte();
        }
    }
}
