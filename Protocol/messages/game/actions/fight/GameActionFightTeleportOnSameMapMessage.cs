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


    public class GameActionFightTeleportOnSameMapMessage : AbstractGameActionMessage
    {
        
        protected override int ProtocolId { get; set; } = 5528;
        
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
        
        private short m_cellId;
        
        public virtual short CellId
        {
            get
            {
                return m_cellId;
            }
            set
            {
                m_cellId = value;
            }
        }
        
        public GameActionFightTeleportOnSameMapMessage(double targetId, short cellId)
        {
            m_targetId = targetId;
            m_cellId = cellId;
        }
        
        public GameActionFightTeleportOnSameMapMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_targetId);
            writer.WriteShort(m_cellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_targetId = reader.ReadDouble();
            m_cellId = reader.ReadShort();
        }
    }
}
