//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context.Fight
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Types;


    public class GameFightResumeSlaveInfo : NetworkType
    {
        
        public const int ProtocolId = 364;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<GameFightSpellCooldown> m_spellCooldowns;
        
        public virtual List<GameFightSpellCooldown> SpellCooldowns
        {
            get
            {
                return m_spellCooldowns;
            }
            set
            {
                m_spellCooldowns = value;
            }
        }
        
        private double m_slaveId;
        
        public virtual double SlaveId
        {
            get
            {
                return m_slaveId;
            }
            set
            {
                m_slaveId = value;
            }
        }
        
        private byte m_summonCount;
        
        public virtual byte SummonCount
        {
            get
            {
                return m_summonCount;
            }
            set
            {
                m_summonCount = value;
            }
        }
        
        private byte m_bombCount;
        
        public virtual byte BombCount
        {
            get
            {
                return m_bombCount;
            }
            set
            {
                m_bombCount = value;
            }
        }
        
        public GameFightResumeSlaveInfo(List<GameFightSpellCooldown> spellCooldowns, double slaveId, byte summonCount, byte bombCount)
        {
            m_spellCooldowns = spellCooldowns;
            m_slaveId = slaveId;
            m_summonCount = summonCount;
            m_bombCount = bombCount;
        }
        
        public GameFightResumeSlaveInfo()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_spellCooldowns.Count)));
            int spellCooldownsIndex;
            for (spellCooldownsIndex = 0; (spellCooldownsIndex < m_spellCooldowns.Count); spellCooldownsIndex = (spellCooldownsIndex + 1))
            {
                GameFightSpellCooldown objectToSend = m_spellCooldowns[spellCooldownsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteDouble(m_slaveId);
            writer.WriteByte(m_summonCount);
            writer.WriteByte(m_bombCount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int spellCooldownsCount = reader.ReadUShort();
            int spellCooldownsIndex;
            m_spellCooldowns = new System.Collections.Generic.List<GameFightSpellCooldown>();
            for (spellCooldownsIndex = 0; (spellCooldownsIndex < spellCooldownsCount); spellCooldownsIndex = (spellCooldownsIndex + 1))
            {
                GameFightSpellCooldown objectToAdd = new GameFightSpellCooldown();
                objectToAdd.Deserialize(reader);
                m_spellCooldowns.Add(objectToAdd);
            }
            m_slaveId = reader.ReadDouble();
            m_summonCount = reader.ReadByte();
            m_bombCount = reader.ReadByte();
        }
    }
}
