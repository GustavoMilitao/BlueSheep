//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Roleplay.Job
{
    using BlueSheep.Protocol;


    public class JobCrafterDirectoryRemoveMessage : Message
    {
        
        public const int ProtocolId = 5653;
        
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
        
        private ulong m_playerId;
        
        public virtual ulong PlayerId
        {
            get
            {
                return m_playerId;
            }
            set
            {
                m_playerId = value;
            }
        }
        
        public JobCrafterDirectoryRemoveMessage(byte jobId, ulong playerId)
        {
            m_jobId = jobId;
            m_playerId = playerId;
        }
        
        public JobCrafterDirectoryRemoveMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_jobId);
            writer.WriteVarLong(m_playerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_jobId = reader.ReadByte();
            m_playerId = reader.ReadVarUhLong();
        }
    }
}