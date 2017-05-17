//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Guild
{
    using MageBot.Protocol.Types.Game.Guild;


    public class GuildCreationValidMessage : Message
    {
        
        public override int ProtocolId { get; } = 5546;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildEmblem m_guildEmblem;
        
        public virtual GuildEmblem GuildEmblem
        {
            get
            {
                return m_guildEmblem;
            }
            set
            {
                m_guildEmblem = value;
            }
        }
        
        private string m_guildName;
        
        public virtual string GuildName
        {
            get
            {
                return m_guildName;
            }
            set
            {
                m_guildName = value;
            }
        }
        
        public GuildCreationValidMessage(GuildEmblem guildEmblem, string guildName)
        {
            m_guildEmblem = guildEmblem;
            m_guildName = guildName;
        }
        
        public GuildCreationValidMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_guildEmblem.Serialize(writer);
            writer.WriteUTF(m_guildName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_guildEmblem = new GuildEmblem();
            m_guildEmblem.Deserialize(reader);
            m_guildName = reader.ReadUTF();
        }
    }
}
