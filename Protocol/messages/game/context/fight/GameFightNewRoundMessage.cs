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
    public class GameFightNewRoundMessage : Message
    {
        
        public override int ProtocolId { get; } = 6239;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_roundNumber;
        
        public virtual uint RoundNumber
        {
            get
            {
                return m_roundNumber;
            }
            set
            {
                m_roundNumber = value;
            }
        }
        
        public GameFightNewRoundMessage(uint roundNumber)
        {
            m_roundNumber = roundNumber;
        }
        
        public GameFightNewRoundMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_roundNumber);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_roundNumber = reader.ReadVarUhInt();
        }
    }
}
