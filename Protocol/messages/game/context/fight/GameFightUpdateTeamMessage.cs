//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Fight
{
    using MageBot.Protocol.Types.Game.Context.Fight;


    public class GameFightUpdateTeamMessage : Message
    {
        
        public override int ProtocolId { get; } = 5572;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private FightTeamInformations m_team;
        
        public virtual FightTeamInformations Team
        {
            get
            {
                return m_team;
            }
            set
            {
                m_team = value;
            }
        }
        
        private short m_fightId;
        
        public virtual short FightId
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
        
        public GameFightUpdateTeamMessage(FightTeamInformations team, short fightId)
        {
            m_team = team;
            m_fightId = fightId;
        }
        
        public GameFightUpdateTeamMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_team.Serialize(writer);
            writer.WriteShort(m_fightId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_team = new FightTeamInformations();
            m_team.Deserialize(reader);
            m_fightId = reader.ReadShort();
        }
    }
}
