//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Fight.Arena
{
    public class GameRolePlayArenaFightAnswerMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6279;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_fightId;
        
        public virtual int FightId
        {
            get
            {
                return m_fightId;
            }
            set
            {
                m_fightId = value;
            }
        }
        
        private bool m_accept;
        
        public virtual bool Accept
        {
            get
            {
                return m_accept;
            }
            set
            {
                m_accept = value;
            }
        }
        
        public GameRolePlayArenaFightAnswerMessage(int fightId, bool accept)
        {
            m_fightId = fightId;
            m_accept = accept;
        }
        
        public GameRolePlayArenaFightAnswerMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_fightId);
            writer.WriteBoolean(m_accept);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_fightId = reader.ReadInt();
            m_accept = reader.ReadBoolean();
        }
    }
}
