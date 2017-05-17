//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Chat.Report
{
    public class ChatMessageReportMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 821;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_senderName;
        
        public virtual string SenderName
        {
            get
            {
                return m_senderName;
            }
            set
            {
                m_senderName = value;
            }
        }
        
        private string m_content;
        
        public virtual string Content
        {
            get
            {
                return m_content;
            }
            set
            {
                m_content = value;
            }
        }
        
        private int m_timestamp;
        
        public virtual int Timestamp
        {
            get
            {
                return m_timestamp;
            }
            set
            {
                m_timestamp = value;
            }
        }
        
        private byte m_channel;
        
        public virtual byte Channel
        {
            get
            {
                return m_channel;
            }
            set
            {
                m_channel = value;
            }
        }
        
        private string m_fingerprint;
        
        public virtual string Fingerprint
        {
            get
            {
                return m_fingerprint;
            }
            set
            {
                m_fingerprint = value;
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
        
        public ChatMessageReportMessage(string senderName, string content, int timestamp, byte channel, string fingerprint, byte reason)
        {
            m_senderName = senderName;
            m_content = content;
            m_timestamp = timestamp;
            m_channel = channel;
            m_fingerprint = fingerprint;
            m_reason = reason;
        }
        
        public ChatMessageReportMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_senderName);
            writer.WriteUTF(m_content);
            writer.WriteInt(m_timestamp);
            writer.WriteByte(m_channel);
            writer.WriteUTF(m_fingerprint);
            writer.WriteByte(m_reason);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_senderName = reader.ReadUTF();
            m_content = reader.ReadUTF();
            m_timestamp = reader.ReadInt();
            m_channel = reader.ReadByte();
            m_fingerprint = reader.ReadUTF();
            m_reason = reader.ReadByte();
        }
    }
}
