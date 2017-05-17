//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Roleplay
{


    public class HumanOptionAlliance : HumanOption
    {
        
        public override int ProtocolId { get; } = 425;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private AllianceInformations m_allianceInformations;
        
        public virtual AllianceInformations AllianceInformations
        {
            get
            {
                return m_allianceInformations;
            }
            set
            {
                m_allianceInformations = value;
            }
        }
        
        private byte m_aggressable;
        
        public virtual byte Aggressable
        {
            get
            {
                return m_aggressable;
            }
            set
            {
                m_aggressable = value;
            }
        }
        
        public HumanOptionAlliance(AllianceInformations allianceInformations, byte aggressable)
        {
            m_allianceInformations = allianceInformations;
            m_aggressable = aggressable;
        }
        
        public HumanOptionAlliance()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_allianceInformations.Serialize(writer);
            writer.WriteByte(m_aggressable);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_allianceInformations = new AllianceInformations();
            m_allianceInformations.Deserialize(reader);
            m_aggressable = reader.ReadByte();
        }
    }
}
