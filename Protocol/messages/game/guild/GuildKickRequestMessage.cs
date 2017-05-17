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
    public class GuildKickRequestMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5887;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_kickedId;
        
        public virtual ulong KickedId
        {
            get
            {
                return m_kickedId;
            }
            set
            {
                m_kickedId = value;
            }
        }
        
        public GuildKickRequestMessage(ulong kickedId)
        {
            m_kickedId = kickedId;
        }
        
        public GuildKickRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_kickedId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_kickedId = reader.ReadVarUhLong();
        }
    }
}
