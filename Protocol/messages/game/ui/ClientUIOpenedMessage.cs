//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Ui
{
    public class ClientUIOpenedMessage : Message
    {
        
        public override int ProtocolId { get; } = 6459;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_type;
        
        public virtual byte Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
            }
        }
        
        public ClientUIOpenedMessage(byte type)
        {
            m_type = type;
        }
        
        public ClientUIOpenedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_type);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_type = reader.ReadByte();
        }
    }
}
