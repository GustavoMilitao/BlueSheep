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
    public class GuildLevelUpMessage : Message
    {
        
        public override int ProtocolId { get; } = 6062;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_newLevel;
        
        public virtual sbyte NewLevel
        {
            get
            {
                return m_newLevel;
            }
            set
            {
                m_newLevel = value;
            }
        }
        
        public GuildLevelUpMessage(sbyte newLevel)
        {
            m_newLevel = newLevel;
        }
        
        public GuildLevelUpMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSByte(m_newLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_newLevel = reader.ReadSByte();
        }
    }
}
