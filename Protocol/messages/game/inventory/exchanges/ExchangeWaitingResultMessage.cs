//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Inventory.Exchanges
{
    public class ExchangeWaitingResultMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5786;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_bwait;
        
        public virtual bool Bwait
        {
            get
            {
                return m_bwait;
            }
            set
            {
                m_bwait = value;
            }
        }
        
        public ExchangeWaitingResultMessage(bool bwait)
        {
            m_bwait = bwait;
        }
        
        public ExchangeWaitingResultMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_bwait);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_bwait = reader.ReadBoolean();
        }
    }
}
