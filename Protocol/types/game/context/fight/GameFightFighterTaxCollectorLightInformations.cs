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


    public class GameFightFighterTaxCollectorLightInformations : GameFightFighterLightInformations
    {
        
        protected override int ProtocolId { get; set; } = 457;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_firstNameId;
        
        public virtual ushort FirstNameId
        {
            get
            {
                return m_firstNameId;
            }
            set
            {
                m_firstNameId = value;
            }
        }
        
        private ushort m_lastNameId;
        
        public virtual ushort LastNameId
        {
            get
            {
                return m_lastNameId;
            }
            set
            {
                m_lastNameId = value;
            }
        }
        
        public GameFightFighterTaxCollectorLightInformations(ushort firstNameId, ushort lastNameId)
        {
            m_firstNameId = firstNameId;
            m_lastNameId = lastNameId;
        }
        
        public GameFightFighterTaxCollectorLightInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort(m_firstNameId);
            writer.WriteVarShort(m_lastNameId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_firstNameId = reader.ReadVarUhShort();
            m_lastNameId = reader.ReadVarUhShort();
        }
    }
}
