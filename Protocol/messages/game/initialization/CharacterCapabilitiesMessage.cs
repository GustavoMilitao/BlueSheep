//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Initialization
{
    public class CharacterCapabilitiesMessage : Message
    {
        
        public override int ProtocolId { get; } = 6339;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_guildEmblemSymbolCategories;
        
        public virtual uint GuildEmblemSymbolCategories
        {
            get
            {
                return m_guildEmblemSymbolCategories;
            }
            set
            {
                m_guildEmblemSymbolCategories = value;
            }
        }
        
        public CharacterCapabilitiesMessage(uint guildEmblemSymbolCategories)
        {
            m_guildEmblemSymbolCategories = guildEmblemSymbolCategories;
        }
        
        public CharacterCapabilitiesMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_guildEmblemSymbolCategories);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_guildEmblemSymbolCategories = reader.ReadVarUhInt();
        }
    }
}
