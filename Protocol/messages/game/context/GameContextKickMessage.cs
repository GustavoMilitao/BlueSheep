//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context
{
    public class GameContextKickMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6081;
        
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
        
        public GameContextKickMessage(double targetId)
        {
            m_targetId = targetId;
        }
        
        public GameContextKickMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(m_targetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_targetId = reader.ReadDouble();
        }
    }
}
