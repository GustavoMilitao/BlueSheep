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
    public class KrosmasterAuthTokenMessage : Message
    {
        
        public override int ProtocolId { get; } = 6351;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_token;
        
        public virtual string Token
        {
            get
            {
                return m_token;
            }
            set
            {
                m_token = value;
            }
        }
        
        public KrosmasterAuthTokenMessage(string token)
        {
            m_token = token;
        }
        
        public KrosmasterAuthTokenMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_token);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_token = reader.ReadUTF();
        }
    }
}
