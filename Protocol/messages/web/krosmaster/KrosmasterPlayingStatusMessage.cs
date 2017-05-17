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
    public class KrosmasterPlayingStatusMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6347;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_playing;
        
        public virtual bool Playing
        {
            get
            {
                return m_playing;
            }
            set
            {
                m_playing = value;
            }
        }
        
        public KrosmasterPlayingStatusMessage(bool playing)
        {
            m_playing = playing;
        }
        
        public KrosmasterPlayingStatusMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_playing);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_playing = reader.ReadBoolean();
        }
    }
}
