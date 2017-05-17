//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Pvp
{
    public class UpdateSelfAgressableStatusMessage : Message
    {
        
        public override int ProtocolId { get; } = 6456;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_status;
        
        public virtual byte Status
        {
            get
            {
                return m_status;
            }
            set
            {
                m_status = value;
            }
        }
        
        private int m_probationTime;
        
        public virtual int ProbationTime
        {
            get
            {
                return m_probationTime;
            }
            set
            {
                m_probationTime = value;
            }
        }
        
        public UpdateSelfAgressableStatusMessage(byte status, int probationTime)
        {
            m_status = status;
            m_probationTime = probationTime;
        }
        
        public UpdateSelfAgressableStatusMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_status);
            writer.WriteInt(m_probationTime);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_status = reader.ReadByte();
            m_probationTime = reader.ReadInt();
        }
    }
}
