//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Party
{


    public class PartyFollowStatusUpdateMessage : AbstractPartyMessage
    {
        
        public override int ProtocolId { get; } = 5581;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_success;
        
        public virtual bool Success
        {
            get
            {
                return m_success;
            }
            set
            {
                m_success = value;
            }
        }
        
        private bool m_isFollowed;
        
        public virtual bool IsFollowed
        {
            get
            {
                return m_isFollowed;
            }
            set
            {
                m_isFollowed = value;
            }
        }
        
        private ulong m_followedId;
        
        public virtual ulong FollowedId
        {
            get
            {
                return m_followedId;
            }
            set
            {
                m_followedId = value;
            }
        }
        
        public PartyFollowStatusUpdateMessage(bool success, bool isFollowed, ulong followedId)
        {
            m_success = success;
            m_isFollowed = isFollowed;
            m_followedId = followedId;
        }
        
        public PartyFollowStatusUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            byte flag = new byte();
            BooleanByteWrapper.SetFlag(0, flag, m_success);
            BooleanByteWrapper.SetFlag(1, flag, m_isFollowed);
            writer.WriteByte(flag);
            writer.WriteVarLong(m_followedId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            byte flag = reader.ReadByte();
            m_success = BooleanByteWrapper.GetFlag(flag, 0);
            m_isFollowed = BooleanByteWrapper.GetFlag(flag, 1);
            m_followedId = reader.ReadVarUhLong();
        }
    }
}
