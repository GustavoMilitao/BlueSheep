//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Prism
{
    using MageBot.Protocol.Types.Game.Character;
    using MageBot.Protocol.Types;


    public class PrismFightAttackerAddMessage : Message
    {
        
        public override int ProtocolId { get; } = 5893;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private CharacterMinimalPlusLookInformations m_attacker;
        
        public virtual CharacterMinimalPlusLookInformations Attacker
        {
            get
            {
                return m_attacker;
            }
            set
            {
                m_attacker = value;
            }
        }
        
        private ushort m_subAreaId;
        
        public virtual ushort SubAreaId
        {
            get
            {
                return m_subAreaId;
            }
            set
            {
                m_subAreaId = value;
            }
        }
        
        private ushort m_fightId;
        
        public virtual ushort FightId
        {
            get
            {
                return m_fightId;
            }
            set
            {
                m_fightId = value;
            }
        }
        
        public PrismFightAttackerAddMessage(CharacterMinimalPlusLookInformations attacker, ushort subAreaId, ushort fightId)
        {
            m_attacker = attacker;
            m_subAreaId = subAreaId;
            m_fightId = fightId;
        }
        
        public PrismFightAttackerAddMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(((ushort)(m_attacker.TypeID)));
            m_attacker.Serialize(writer);
            writer.WriteVarShort(m_subAreaId);
            writer.WriteVarShort(m_fightId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_attacker = ProtocolTypeManager.GetInstance<CharacterMinimalPlusLookInformations>(reader.ReadUShort());
            m_attacker.Deserialize(reader);
            m_subAreaId = reader.ReadVarUhShort();
            m_fightId = reader.ReadVarUhShort();
        }
    }
}
