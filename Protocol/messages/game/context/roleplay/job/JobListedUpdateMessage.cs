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
    public class JobListedUpdateMessage : Message
    {
        
        public override int ProtocolId { get; } = 6016;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_addedOrDeleted;
        
        public virtual bool AddedOrDeleted
        {
            get
            {
                return m_addedOrDeleted;
            }
            set
            {
                m_addedOrDeleted = value;
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
        
        public JobListedUpdateMessage(bool addedOrDeleted, byte jobId)
        {
            m_addedOrDeleted = addedOrDeleted;
            m_jobId = jobId;
        }
        
        public JobListedUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_addedOrDeleted);
            writer.WriteByte(m_jobId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_addedOrDeleted = reader.ReadBoolean();
            m_jobId = reader.ReadByte();
        }
    }
}
