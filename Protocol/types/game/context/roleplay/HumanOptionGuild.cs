//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Roleplay
{


    public class HumanOptionGuild : HumanOption
    {
        
        protected override int ProtocolId { get; set; } = 409;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildInformations m_guildInformations;
        
        public virtual GuildInformations GuildInformations
        {
            get
            {
                return m_guildInformations;
            }
            set
            {
                m_guildInformations = value;
            }
        }
        
        public HumanOptionGuild(GuildInformations guildInformations)
        {
            m_guildInformations = guildInformations;
        }
        
        public HumanOptionGuild()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_guildInformations.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_guildInformations = new GuildInformations();
            m_guildInformations.Deserialize(reader);
        }
    }
}
