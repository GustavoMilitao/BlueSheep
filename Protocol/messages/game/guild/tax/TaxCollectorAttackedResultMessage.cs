//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Guild.Tax
{
    using MageBot.Protocol.Types.Game.Guild.Tax;
    using MageBot.Protocol.Types.Game.Context.Roleplay;


    public class TaxCollectorAttackedResultMessage : Message
    {
        
        public override int ProtocolId { get; } = 5635;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private TaxCollectorBasicInformations m_basicInfos;
        
        public virtual TaxCollectorBasicInformations BasicInfos
        {
            get
            {
                return m_basicInfos;
            }
            set
            {
                m_basicInfos = value;
            }
        }
        
        private BasicGuildInformations m_guild;
        
        public virtual BasicGuildInformations Guild
        {
            get
            {
                return m_guild;
            }
            set
            {
                m_guild = value;
            }
        }
        
        private bool m_deadOrAlive;
        
        public virtual bool DeadOrAlive
        {
            get
            {
                return m_deadOrAlive;
            }
            set
            {
                m_deadOrAlive = value;
            }
        }
        
        public TaxCollectorAttackedResultMessage(TaxCollectorBasicInformations basicInfos, BasicGuildInformations guild, bool deadOrAlive)
        {
            m_basicInfos = basicInfos;
            m_guild = guild;
            m_deadOrAlive = deadOrAlive;
        }
        
        public TaxCollectorAttackedResultMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_basicInfos.Serialize(writer);
            m_guild.Serialize(writer);
            writer.WriteBoolean(m_deadOrAlive);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_basicInfos = new TaxCollectorBasicInformations();
            m_basicInfos.Deserialize(reader);
            m_guild = new BasicGuildInformations();
            m_guild.Deserialize(reader);
            m_deadOrAlive = reader.ReadBoolean();
        }
    }
}
