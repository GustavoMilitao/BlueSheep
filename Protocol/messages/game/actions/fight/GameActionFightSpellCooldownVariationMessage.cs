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
    using MageBot.Protocol.Messages.Game.Actions;


    public class GameActionFightSpellCooldownVariationMessage : AbstractGameActionMessage
    {
        
        protected override int ProtocolId { get; set; } = 6219;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_targetId;
        
        public virtual double TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        private ushort m_spellId;
        
        public virtual ushort SpellId
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
        
        private short m_value;
        
        public virtual short Value
        {
            get
            {
                return m_value;
            }
            set
            {
                m_value = value;
            }
        }
        
        public GameActionFightSpellCooldownVariationMessage(double targetId, ushort spellId, short value)
        {
            m_targetId = targetId;
            m_spellId = spellId;
            m_value = value;
        }
        
        public GameActionFightSpellCooldownVariationMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_targetId);
            writer.WriteVarShort(m_spellId);
            writer.WriteVarShort(m_value);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_targetId = reader.ReadDouble();
            m_spellId = reader.ReadVarUhShort();
            m_value = reader.ReadVarShort();
        }
    }
}
