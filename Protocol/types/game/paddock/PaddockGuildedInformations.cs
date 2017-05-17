//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Paddock
{
    using MageBot.Protocol.Types.Game.Context.Roleplay;


    public class PaddockGuildedInformations : PaddockBuyableInformations
    {
        
        protected override int ProtocolId { get; set; } = 508;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildInformations m_guildInfo;
        
        public virtual GuildInformations GuildInfo
        {
            get
            {
                return m_guildInfo;
            }
            set
            {
                m_guildInfo = value;
            }
        }
        
        private bool m_deserted;
        
        public virtual bool Deserted
        {
            get
            {
                return m_deserted;
            }
            set
            {
                m_deserted = value;
            }
        }
        
        public PaddockGuildedInformations(GuildInformations guildInfo, bool deserted)
        {
            m_guildInfo = guildInfo;
            m_deserted = deserted;
        }
        
        public PaddockGuildedInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_guildInfo.Serialize(writer);
            writer.WriteBoolean(m_deserted);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_guildInfo = new GuildInformations();
            m_guildInfo.Deserialize(reader);
            m_deserted = reader.ReadBoolean();
        }
    }
}
