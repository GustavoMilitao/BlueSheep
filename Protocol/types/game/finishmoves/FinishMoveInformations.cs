//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Finishmoves
{
    using MageBot.Protocol.Types;


    public class FinishMoveInformations : NetworkType
    {
        
        protected override int ProtocolId { get; set; } = 506;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_finishMoveId;
        
        public virtual int FinishMoveId
        {
            get
            {
                return m_finishMoveId;
            }
            set
            {
                m_finishMoveId = value;
            }
        }
        
        private bool m_finishMoveState;
        
        public virtual bool FinishMoveState
        {
            get
            {
                return m_finishMoveState;
            }
            set
            {
                m_finishMoveState = value;
            }
        }
        
        public FinishMoveInformations(int finishMoveId, bool finishMoveState)
        {
            m_finishMoveId = finishMoveId;
            m_finishMoveState = finishMoveState;
        }
        
        public FinishMoveInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_finishMoveId);
            writer.WriteBoolean(m_finishMoveState);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_finishMoveId = reader.ReadInt();
            m_finishMoveState = reader.ReadBoolean();
        }
    }
}
