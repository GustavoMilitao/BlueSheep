//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Interactive
{


    public class InteractiveElementWithAgeBonus : InteractiveElement
    {
        
        protected override int ProtocolId { get; set; } = 398;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private short m_ageBonus;
        
        public virtual short AgeBonus
        {
            get
            {
                return m_ageBonus;
            }
            set
            {
                m_ageBonus = value;
            }
        }
        
        public InteractiveElementWithAgeBonus(short ageBonus)
        {
            m_ageBonus = ageBonus;
        }
        
        public InteractiveElementWithAgeBonus()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(m_ageBonus);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_ageBonus = reader.ReadShort();
        }
    }
}
