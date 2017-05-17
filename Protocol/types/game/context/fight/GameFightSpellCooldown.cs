//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Fight
{
    using MageBot.Protocol.Types;


    public class GameFightSpellCooldown : NetworkType
    {
        
        public override int ProtocolId { get; } = 205;
        
        public override int TypeID
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
        
        private byte m_cooldown;
        
        public virtual byte Cooldown
        {
            get
            {
                return m_cooldown;
            }
            set
            {
                m_cooldown = value;
            }
        }
        
        public GameFightSpellCooldown(int spellId, byte cooldown)
        {
            m_spellId = spellId;
            m_cooldown = cooldown;
        }
        
        public GameFightSpellCooldown()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_spellId);
            writer.WriteByte(m_cooldown);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_spellId = reader.ReadInt();
            m_cooldown = reader.ReadByte();
        }
    }
}
