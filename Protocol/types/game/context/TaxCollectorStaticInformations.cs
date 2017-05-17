//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context
{
    using MageBot.Protocol.Types.Game.Context.Roleplay;
    using MageBot.Protocol.Types;


    public class TaxCollectorStaticInformations : NetworkType
    {
        
        protected override int ProtocolId { get; set; } = 147;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildInformations m_guildIdentity;
        
        public virtual GuildInformations GuildIdentity
        {
            get
            {
                return m_guildIdentity;
            }
            set
            {
                m_guildIdentity = value;
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
        
        public TaxCollectorStaticInformations(GuildInformations guildIdentity, ushort firstNameId, ushort lastNameId)
        {
            m_guildIdentity = guildIdentity;
            m_firstNameId = firstNameId;
            m_lastNameId = lastNameId;
        }
        
        public TaxCollectorStaticInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_guildIdentity.Serialize(writer);
            writer.WriteVarShort(m_firstNameId);
            writer.WriteVarShort(m_lastNameId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_guildIdentity = new GuildInformations();
            m_guildIdentity.Deserialize(reader);
            m_firstNameId = reader.ReadVarUhShort();
            m_lastNameId = reader.ReadVarUhShort();
        }
    }
}
