//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Fight
{
    public class GameFightPlacementSwapPositionsCancelMessage : Message
    {
        
        public override int ProtocolId { get; } = 6543;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_requestId;
        
        public virtual int RequestId
        {
            get
            {
                return m_requestId;
            }
            set
            {
                m_requestId = value;
            }
        }
        
        public GameFightPlacementSwapPositionsCancelMessage(int requestId)
        {
            m_requestId = requestId;
        }
        
        public GameFightPlacementSwapPositionsCancelMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_requestId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_requestId = reader.ReadInt();
        }
    }
}
