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
    public class GuildInvitationStateRecrutedMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5548;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_invitationState;
        
        public virtual byte InvitationState
        {
            get
            {
                return m_invitationState;
            }
            set
            {
                m_invitationState = value;
            }
        }
        
        public GuildInvitationStateRecrutedMessage(byte invitationState)
        {
            m_invitationState = invitationState;
        }
        
        public GuildInvitationStateRecrutedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_invitationState);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_invitationState = reader.ReadByte();
        }
    }
}
