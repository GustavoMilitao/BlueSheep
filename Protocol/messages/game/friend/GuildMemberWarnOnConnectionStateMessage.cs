//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Friend
{
    public class GuildMemberWarnOnConnectionStateMessage : Message
    {
        
        public override int ProtocolId { get; } = 6160;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_enable;
        
        public virtual bool Enable
        {
            get
            {
                return m_enable;
            }
            set
            {
                m_enable = value;
            }
        }
        
        public GuildMemberWarnOnConnectionStateMessage(bool enable)
        {
            m_enable = enable;
        }
        
        public GuildMemberWarnOnConnectionStateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_enable);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_enable = reader.ReadBoolean();
        }
    }
}
