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
    using MageBot.Protocol.Types.Game.Context.Roleplay;


    public class GuildInAllianceFactsMessage : GuildFactsMessage
    {
        
        public override int ProtocolId { get; } = 6422;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private BasicNamedAllianceInformations m_allianceInfos;
        
        public virtual BasicNamedAllianceInformations AllianceInfos
        {
            get
            {
                return m_allianceInfos;
            }
            set
            {
                m_allianceInfos = value;
            }
        }
        
        public GuildInAllianceFactsMessage(BasicNamedAllianceInformations allianceInfos)
        {
            m_allianceInfos = allianceInfos;
        }
        
        public GuildInAllianceFactsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_allianceInfos.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_allianceInfos = new BasicNamedAllianceInformations();
            m_allianceInfos.Deserialize(reader);
        }
    }
}
