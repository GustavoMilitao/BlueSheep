//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Spell
{
    using System.Collections.Generic;


    public class SpellForgottenMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5834;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_spellsId;
        
        public virtual List<System.UInt16> SpellsId
        {
            get
            {
                return m_spellsId;
            }
            set
            {
                m_spellsId = value;
            }
        }
        
        private ushort m_boostPoint;
        
        public virtual ushort BoostPoint
        {
            get
            {
                return m_boostPoint;
            }
            set
            {
                m_boostPoint = value;
            }
        }
        
        public SpellForgottenMessage(List<System.UInt16> spellsId, ushort boostPoint)
        {
            m_spellsId = spellsId;
            m_boostPoint = boostPoint;
        }
        
        public SpellForgottenMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_spellsId.Count)));
            int spellsIdIndex;
            for (spellsIdIndex = 0; (spellsIdIndex < m_spellsId.Count); spellsIdIndex = (spellsIdIndex + 1))
            {
                writer.WriteVarShort(m_spellsId[spellsIdIndex]);
            }
            writer.WriteVarShort(m_boostPoint);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int spellsIdCount = reader.ReadUShort();
            int spellsIdIndex;
            m_spellsId = new System.Collections.Generic.List<ushort>();
            for (spellsIdIndex = 0; (spellsIdIndex < spellsIdCount); spellsIdIndex = (spellsIdIndex + 1))
            {
                m_spellsId.Add(reader.ReadVarUhShort());
            }
            m_boostPoint = reader.ReadVarUhShort();
        }
    }
}
