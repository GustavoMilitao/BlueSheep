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
    public class GuildSpellUpgradeRequestMessage : Message
    {
        
        public override int ProtocolId { get; } = 5699;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_spellId;
        
        public virtual int SpellId
        {
            get
            {
                return m_spellId;
            }
            set
            {
                m_spellId = value;
            }
        }
        
        public GuildSpellUpgradeRequestMessage(int spellId)
        {
            m_spellId = spellId;
        }
        
        public GuildSpellUpgradeRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_spellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_spellId = reader.ReadInt();
        }
    }
}
