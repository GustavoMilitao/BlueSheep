//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Roleplay.Party
{
    using MageBot.Protocol.Types;


    public class NamedPartyTeamWithOutcome : NetworkType
    {
        
        protected override int ProtocolId { get; set; } = 470;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private NamedPartyTeam m_team;
        
        public virtual NamedPartyTeam Team
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
        
        private ushort m_outcome;
        
        public virtual ushort Outcome
        {
            get
            {
                return m_outcome;
            }
            set
            {
                m_outcome = value;
            }
        }
        
        public NamedPartyTeamWithOutcome(NamedPartyTeam team, ushort outcome)
        {
            m_team = team;
            m_outcome = outcome;
        }
        
        public NamedPartyTeamWithOutcome()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_team.Serialize(writer);
            writer.WriteVarShort(m_outcome);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_team = new NamedPartyTeam();
            m_team.Deserialize(reader);
            m_outcome = reader.ReadVarUhShort();
        }
    }
}
