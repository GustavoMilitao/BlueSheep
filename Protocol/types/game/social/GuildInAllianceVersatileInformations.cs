//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Social
{


    public class GuildInAllianceVersatileInformations : GuildVersatileInformations
    {
        
        public override int ProtocolId { get; } = 437;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_allianceId;
        
        public virtual uint AllianceId
        {
            get
            {
                return m_allianceId;
            }
            set
            {
                m_allianceId = value;
            }
        }
        
        public GuildInAllianceVersatileInformations(uint allianceId)
        {
            m_allianceId = allianceId;
        }
        
        public GuildInAllianceVersatileInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt(m_allianceId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_allianceId = reader.ReadVarUhInt();
        }
    }
}
