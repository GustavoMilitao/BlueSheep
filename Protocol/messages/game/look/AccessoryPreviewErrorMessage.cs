//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Look
{
    public class AccessoryPreviewErrorMessage : Message
    {
        
        public override int ProtocolId { get; } = 6521;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_error;
        
        public virtual byte Error
        {
            get
            {
                return m_error;
            }
            set
            {
                m_error = value;
            }
        }
        
        public AccessoryPreviewErrorMessage(byte error)
        {
            m_error = error;
        }
        
        public AccessoryPreviewErrorMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_error);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_error = reader.ReadByte();
        }
    }
}
