//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Actions.Fight
{
    public class GameActionFightNoSpellCastMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6132;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_spellLevelId;
        
        public virtual uint SpellLevelId
        {
            get
            {
                return m_spellLevelId;
            }
            set
            {
                m_spellLevelId = value;
            }
        }
        
        public GameActionFightNoSpellCastMessage(uint spellLevelId)
        {
            m_spellLevelId = spellLevelId;
        }
        
        public GameActionFightNoSpellCastMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_spellLevelId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_spellLevelId = reader.ReadVarUhInt();
        }
    }
}
