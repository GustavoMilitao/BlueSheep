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


    public class GameActionFightCloseCombatMessage : AbstractGameActionFightTargetedAbilityMessage
    {
        
        public override int ProtocolId { get; } = 6116;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_weaponGenericId;
        
        public virtual ushort WeaponGenericId
        {
            get
            {
                return m_weaponGenericId;
            }
            set
            {
                m_weaponGenericId = value;
            }
        }
        
        public GameActionFightCloseCombatMessage(ushort weaponGenericId)
        {
            m_weaponGenericId = weaponGenericId;
        }
        
        public GameActionFightCloseCombatMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort(m_weaponGenericId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_weaponGenericId = reader.ReadVarUhShort();
        }
    }
}
