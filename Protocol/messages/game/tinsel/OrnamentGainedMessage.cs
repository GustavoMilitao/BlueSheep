//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Tinsel
{
    public class OrnamentGainedMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6368;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private short m_ornamentId;
        
        public virtual short OrnamentId
        {
            get
            {
                return m_ornamentId;
            }
            set
            {
                m_ornamentId = value;
            }
        }
        
        public OrnamentGainedMessage(short ornamentId)
        {
            m_ornamentId = ornamentId;
        }
        
        public OrnamentGainedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(m_ornamentId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_ornamentId = reader.ReadShort();
        }
    }
}
