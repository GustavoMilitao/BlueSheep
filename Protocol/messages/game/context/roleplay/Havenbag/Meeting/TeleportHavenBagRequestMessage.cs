//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Havenbag.Meeting
{
    public class TeleportHavenBagRequestMessage : Message
    {
        
        public override int ProtocolId { get; } = 6647;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_guestId;
        
        public virtual ulong GuestId
        {
            get
            {
                return m_guestId;
            }
            set
            {
                m_guestId = value;
            }
        }
        
        public TeleportHavenBagRequestMessage(ulong guestId)
        {
            m_guestId = guestId;
        }
        
        public TeleportHavenBagRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_guestId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_guestId = reader.ReadVarUhLong();
        }
    }
}
