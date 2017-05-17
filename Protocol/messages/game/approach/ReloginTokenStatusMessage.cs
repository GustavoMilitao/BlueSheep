//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Approach
{
    using System.Collections.Generic;


    public class ReloginTokenStatusMessage : Message
    {
        
        public override int ProtocolId { get; } = 6539;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Byte> m_ticket;
        
        public virtual List<System.Byte> Ticket
        {
            get
            {
                return m_ticket;
            }
            set
            {
                m_ticket = value;
            }
        }
        
        private bool m_validToken;
        
        public virtual bool ValidToken
        {
            get
            {
                return m_validToken;
            }
            set
            {
                m_validToken = value;
            }
        }
        
        public ReloginTokenStatusMessage(List<System.Byte> ticket, bool validToken)
        {
            m_ticket = ticket;
            m_validToken = validToken;
        }
        
        public ReloginTokenStatusMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_ticket.Count)));
            int ticketIndex;
            for (ticketIndex = 0; (ticketIndex < m_ticket.Count); ticketIndex = (ticketIndex + 1))
            {
                writer.WriteByte(m_ticket[ticketIndex]);
            }
            writer.WriteBoolean(m_validToken);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int ticketCount = reader.ReadUShort();
            int ticketIndex;
            m_ticket = new System.Collections.Generic.List<byte>();
            for (ticketIndex = 0; (ticketIndex < ticketCount); ticketIndex = (ticketIndex + 1))
            {
                m_ticket.Add(reader.ReadByte());
            }
            m_validToken = reader.ReadBoolean();
        }
    }
}
