//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Mount
{
    public class PaddockBuyResultMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6516;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_paddockId;
        
        public virtual int PaddockId
        {
            get
            {
                return m_paddockId;
            }
            set
            {
                m_paddockId = value;
            }
        }
        
        private bool m_bought;
        
        public virtual bool Bought
        {
            get
            {
                return m_bought;
            }
            set
            {
                m_bought = value;
            }
        }
        
        private ulong m_realPrice;
        
        public virtual ulong RealPrice
        {
            get
            {
                return m_realPrice;
            }
            set
            {
                m_realPrice = value;
            }
        }
        
        public PaddockBuyResultMessage(int paddockId, bool bought, ulong realPrice)
        {
            m_paddockId = paddockId;
            m_bought = bought;
            m_realPrice = realPrice;
        }
        
        public PaddockBuyResultMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_paddockId);
            writer.WriteBoolean(m_bought);
            writer.WriteVarLong(m_realPrice);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_paddockId = reader.ReadInt();
            m_bought = reader.ReadBoolean();
            m_realPrice = reader.ReadVarUhLong();
        }
    }
}
