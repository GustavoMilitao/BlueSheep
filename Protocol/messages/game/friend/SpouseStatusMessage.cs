//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Friend
{
    public class SpouseStatusMessage : Message
    {
        
        public override int ProtocolId { get; } = 6265;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_hasSpouse;
        
        public virtual bool HasSpouse
        {
            get
            {
                return m_hasSpouse;
            }
            set
            {
                m_hasSpouse = value;
            }
        }
        
        public SpouseStatusMessage(bool hasSpouse)
        {
            m_hasSpouse = hasSpouse;
        }
        
        public SpouseStatusMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_hasSpouse);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_hasSpouse = reader.ReadBoolean();
        }
    }
}
