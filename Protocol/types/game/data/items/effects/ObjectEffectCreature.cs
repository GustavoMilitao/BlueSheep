//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Data.Items.Effects
{


    public class ObjectEffectCreature : ObjectEffect
    {
        
        public override int ProtocolId { get; } = 71;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_monsterFamilyId;
        
        public virtual ushort MonsterFamilyId
        {
            get
            {
                return m_monsterFamilyId;
            }
            set
            {
                m_monsterFamilyId = value;
            }
        }
        
        public ObjectEffectCreature(ushort monsterFamilyId)
        {
            m_monsterFamilyId = monsterFamilyId;
        }
        
        public ObjectEffectCreature()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort(m_monsterFamilyId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_monsterFamilyId = reader.ReadVarUhShort();
        }
    }
}
