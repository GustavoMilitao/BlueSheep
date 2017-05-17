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
    public class PrismFightAttackerRemoveMessage : Message
    {
        
        public override int ProtocolId { get; } = 5897;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
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
        
        private ulong m_fighterToRemoveId;
        
        public virtual ulong FighterToRemoveId
        {
            get
            {
                return m_fighterToRemoveId;
            }
            set
            {
                m_fighterToRemoveId = value;
            }
        }
        
        public PrismFightAttackerRemoveMessage(ushort subAreaId, ushort fightId, ulong fighterToRemoveId)
        {
            m_subAreaId = subAreaId;
            m_fightId = fightId;
            m_fighterToRemoveId = fighterToRemoveId;
        }
        
        public PrismFightAttackerRemoveMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_subAreaId);
            writer.WriteVarShort(m_fightId);
            writer.WriteVarLong(m_fighterToRemoveId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_subAreaId = reader.ReadVarUhShort();
            m_fightId = reader.ReadVarUhShort();
            m_fighterToRemoveId = reader.ReadVarUhLong();
        }
    }
}
