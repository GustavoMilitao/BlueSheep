//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Guild
{
    public class GuildChangeMemberParametersMessage : Message
    {
        
        public override int ProtocolId { get; } = 5549;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_memberId;
        
        public virtual ulong MemberId
        {
            get
            {
                return m_memberId;
            }
            set
            {
                m_memberId = value;
            }
        }
        
        private ushort m_rank;
        
        public virtual ushort Rank
        {
            get
            {
                return m_rank;
            }
            set
            {
                m_rank = value;
            }
        }
        
        private byte m_experienceGivenPercent;
        
        public virtual byte ExperienceGivenPercent
        {
            get
            {
                return m_experienceGivenPercent;
            }
            set
            {
                m_experienceGivenPercent = value;
            }
        }
        
        private uint m_rights;
        
        public virtual uint Rights
        {
            get
            {
                return m_rights;
            }
            set
            {
                m_rights = value;
            }
        }
        
        public GuildChangeMemberParametersMessage(ulong memberId, ushort rank, byte experienceGivenPercent, uint rights)
        {
            m_memberId = memberId;
            m_rank = rank;
            m_experienceGivenPercent = experienceGivenPercent;
            m_rights = rights;
        }
        
        public GuildChangeMemberParametersMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_memberId);
            writer.WriteVarShort(m_rank);
            writer.WriteByte(m_experienceGivenPercent);
            writer.WriteVarInt(m_rights);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_memberId = reader.ReadVarUhLong();
            m_rank = reader.ReadVarUhShort();
            m_experienceGivenPercent = reader.ReadByte();
            m_rights = reader.ReadVarUhInt();
        }
    }
}
