//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Fight
{


    public class FightAllianceTeamInformations : FightTeamInformations
    {
        
        public override int ProtocolId { get; } = 439;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_relation;
        
        public virtual byte Relation
        {
            get
            {
                return m_relation;
            }
            set
            {
                m_relation = value;
            }
        }
        
        public FightAllianceTeamInformations(byte relation)
        {
            m_relation = relation;
        }
        
        public FightAllianceTeamInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_relation);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_relation = reader.ReadByte();
        }
    }
}
