//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Actions
{


    public class AbstractGameActionWithAckMessage : AbstractGameActionMessage
    {
        
        public override int ProtocolId { get; } = 1001;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private short m_waitAckId;
        
        public virtual short WaitAckId
        {
            get
            {
                return m_waitAckId;
            }
            set
            {
                m_waitAckId = value;
            }
        }
        
        public AbstractGameActionWithAckMessage(short waitAckId)
        {
            m_waitAckId = waitAckId;
        }
        
        public AbstractGameActionWithAckMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(m_waitAckId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_waitAckId = reader.ReadShort();
        }
    }
}
