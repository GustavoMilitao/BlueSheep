//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Roleplay
{
    using BlueSheep.Protocol;


    public class TeleportOnSameMapMessage : Message
    {
        
        public const int ProtocolId = 6048;
        
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
        
        private ushort m_cellId;
        
        public virtual ushort CellId
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
        
        public TeleportOnSameMapMessage(double targetId, ushort cellId)
        {
            m_targetId = targetId;
            m_cellId = cellId;
        }
        
        public TeleportOnSameMapMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(m_targetId);
            writer.WriteVarShort(m_cellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_targetId = reader.ReadDouble();
            m_cellId = reader.ReadVarUhShort();
        }
    }
}