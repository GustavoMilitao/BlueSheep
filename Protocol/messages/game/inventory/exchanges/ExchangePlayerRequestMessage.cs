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


    public class ExchangePlayerRequestMessage : ExchangeRequestMessage
    {
        
        public override int ProtocolId { get; } = 5773;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_target;
        
        public virtual ulong Target
        {
            get
            {
                return m_target;
            }
            set
            {
                m_target = value;
            }
        }
        
        public ExchangePlayerRequestMessage(ulong target)
        {
            m_target = target;
        }

        public ExchangePlayerRequestMessage(byte exchangeType, ulong target) : base(exchangeType)
        {
            m_target = target;
        }

        public ExchangePlayerRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(m_target);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_target = reader.ReadVarUhLong();
        }
    }
}
