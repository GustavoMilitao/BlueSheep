//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Achievement
{
    public class AchievementRewardRequestMessage : Message
    {
        
        public override int ProtocolId { get; } = 6377;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private short m_achievementId;
        
        public virtual short AchievementId
        {
            get
            {
                return m_achievementId;
            }
            set
            {
                m_achievementId = value;
            }
        }
        
        public AchievementRewardRequestMessage(short achievementId)
        {
            m_achievementId = achievementId;
        }
        
        public AchievementRewardRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(m_achievementId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_achievementId = reader.ReadShort();
        }
    }
}
