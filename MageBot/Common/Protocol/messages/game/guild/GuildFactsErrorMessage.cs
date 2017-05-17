//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Guild
{
    using BlueSheep.Common;


    public class GuildFactsErrorMessage : Message
    {
        
        public const int ProtocolId = 6424;
        
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
        
        public GuildFactsErrorMessage(uint guildId)
        {
            m_guildId = guildId;
        }
        
        public GuildFactsErrorMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_guildId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_guildId = reader.ReadVarUhInt();
        }
    }
}