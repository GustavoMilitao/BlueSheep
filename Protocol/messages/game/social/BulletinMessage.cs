//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Social
{


    public class BulletinMessage : SocialNoticeMessage
    {
        
        protected override int ProtocolId { get; set; } = 6695;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_lastNotifiedTimestamp;
        
        public virtual int LastNotifiedTimestamp
        {
            get
            {
                return m_lastNotifiedTimestamp;
            }
            set
            {
                m_lastNotifiedTimestamp = value;
            }
        }
        
        public BulletinMessage(int lastNotifiedTimestamp)
        {
            m_lastNotifiedTimestamp = lastNotifiedTimestamp;
        }
        
        public BulletinMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(m_lastNotifiedTimestamp);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_lastNotifiedTimestamp = reader.ReadInt();
        }
    }
}
