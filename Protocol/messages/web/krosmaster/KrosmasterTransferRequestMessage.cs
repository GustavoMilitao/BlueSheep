//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Web.Krosmaster
{
    public class KrosmasterTransferRequestMessage : Message
    {
        
        public override int ProtocolId { get; } = 6349;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_uid;
        
        public virtual string Uid
        {
            get
            {
                return m_uid;
            }
            set
            {
                m_uid = value;
            }
        }
        
        public KrosmasterTransferRequestMessage(string uid)
        {
            m_uid = uid;
        }
        
        public KrosmasterTransferRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_uid);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_uid = reader.ReadUTF();
        }
    }
}
