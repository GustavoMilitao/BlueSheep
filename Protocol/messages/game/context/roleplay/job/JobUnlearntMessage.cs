//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Job
{
    public class JobUnlearntMessage : Message
    {
        
        public override int ProtocolId { get; } = 5657;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_jobId;
        
        public virtual byte JobId
        {
            get
            {
                return m_jobId;
            }
            set
            {
                m_jobId = value;
            }
        }
        
        public JobUnlearntMessage(byte jobId)
        {
            m_jobId = jobId;
        }
        
        public JobUnlearntMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_jobId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_jobId = reader.ReadByte();
        }
    }
}
