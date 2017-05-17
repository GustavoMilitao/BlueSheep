//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Web.Krosmaster
{
    public class KrosmasterTransferMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6348;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_uid;
        
        public virtual string Uid
        {
            get
            {
                return m_uid;
            }
            set
            {
                m_uid = value;
            }
        }
        
        private byte m_failure;
        
        public virtual byte Failure
        {
            get
            {
                return m_failure;
            }
            set
            {
                m_failure = value;
            }
        }
        
        public KrosmasterTransferMessage(string uid, byte failure)
        {
            m_uid = uid;
            m_failure = failure;
        }
        
        public KrosmasterTransferMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_uid);
            writer.WriteByte(m_failure);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_uid = reader.ReadUTF();
            m_failure = reader.ReadByte();
        }
    }
}
