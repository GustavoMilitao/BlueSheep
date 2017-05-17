//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Alliance
{
    public class AllianceGuildLeavingMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6399;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_kicked;
        
        public virtual bool Kicked
        {
            get
            {
                return m_kicked;
            }
            set
            {
                m_kicked = value;
            }
        }
        
        private uint m_guildId;
        
        public virtual uint GuildId
        {
            get
            {
                return m_guildId;
            }
            set
            {
                m_guildId = value;
            }
        }
        
        public AllianceGuildLeavingMessage(bool kicked, uint guildId)
        {
            m_kicked = kicked;
            m_guildId = guildId;
        }
        
        public AllianceGuildLeavingMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_kicked);
            writer.WriteVarInt(m_guildId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_kicked = reader.ReadBoolean();
            m_guildId = reader.ReadVarUhInt();
        }
    }
}
