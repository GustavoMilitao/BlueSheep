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
    using MageBot.Protocol.Types.Game.Paddock;


    public class GuildPaddockBoughtMessage : Message
    {
        
        public override int ProtocolId { get; } = 5952;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private PaddockContentInformations m_paddockInfo;
        
        public virtual PaddockContentInformations PaddockInfo
        {
            get
            {
                return m_paddockInfo;
            }
            set
            {
                m_paddockInfo = value;
            }
        }
        
        public GuildPaddockBoughtMessage(PaddockContentInformations paddockInfo)
        {
            m_paddockInfo = paddockInfo;
        }
        
        public GuildPaddockBoughtMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_paddockInfo.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_paddockInfo = new PaddockContentInformations();
            m_paddockInfo.Deserialize(reader);
        }
    }
}
