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


    public class BasicNamedAllianceInformations : BasicAllianceInformations
    {
        
        public override int ProtocolId { get; } = 418;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_allianceName;
        
        public virtual string AllianceName
        {
            get
            {
                return m_allianceName;
            }
            set
            {
                m_allianceName = value;
            }
        }
        
        public BasicNamedAllianceInformations(string allianceName)
        {
            m_allianceName = allianceName;
        }
        
        public BasicNamedAllianceInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_allianceName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_allianceName = reader.ReadUTF();
        }
    }
}
