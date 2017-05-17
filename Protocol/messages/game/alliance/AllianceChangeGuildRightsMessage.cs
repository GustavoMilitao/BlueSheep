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
    public class AllianceChangeGuildRightsMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6426;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
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
        
        private byte m_rights;
        
        public virtual byte Rights
        {
            get
            {
                return m_rights;
            }
            set
            {
                m_rights = value;
            }
        }
        
        public AllianceChangeGuildRightsMessage(uint guildId, byte rights)
        {
            m_guildId = guildId;
            m_rights = rights;
        }
        
        public AllianceChangeGuildRightsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_guildId);
            writer.WriteByte(m_rights);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_guildId = reader.ReadVarUhInt();
            m_rights = reader.ReadByte();
        }
    }
}
