//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Startup
{
    public class StartupActionsAllAttributionMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6537;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_characterId;
        
        public virtual ulong CharacterId
        {
            get
            {
                return m_characterId;
            }
            set
            {
                m_characterId = value;
            }
        }
        
        public StartupActionsAllAttributionMessage(ulong characterId)
        {
            m_characterId = characterId;
        }
        
        public StartupActionsAllAttributionMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_characterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_characterId = reader.ReadVarUhLong();
        }
    }
}
