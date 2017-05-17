//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Alliance
{
    using MageBot.Protocol.Types.Game.Guild;


    public class AllianceModificationValidMessage : Message
    {
        
        public override int ProtocolId { get; } = 6450;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildEmblem m_Alliancemblem;
        
        public virtual GuildEmblem Alliancemblem
        {
            get
            {
                return m_Alliancemblem;
            }
            set
            {
                m_Alliancemblem = value;
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
        
        private string m_allianceTag;
        
        public virtual string AllianceTag
        {
            get
            {
                return m_allianceTag;
            }
            set
            {
                m_allianceTag = value;
            }
        }
        
        public AllianceModificationValidMessage(GuildEmblem alliancemblem, string allianceName, string allianceTag)
        {
            m_Alliancemblem = alliancemblem;
            m_allianceName = allianceName;
            m_allianceTag = allianceTag;
        }
        
        public AllianceModificationValidMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_Alliancemblem.Serialize(writer);
            writer.WriteUTF(m_allianceName);
            writer.WriteUTF(m_allianceTag);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_Alliancemblem = new GuildEmblem();
            m_Alliancemblem.Deserialize(reader);
            m_allianceName = reader.ReadUTF();
            m_allianceTag = reader.ReadUTF();
        }
    }
}
