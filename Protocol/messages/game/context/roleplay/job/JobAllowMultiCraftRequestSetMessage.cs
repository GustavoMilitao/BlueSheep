//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Job
{
    public class JobAllowMultiCraftRequestSetMessage : Message
    {
        
        public override int ProtocolId { get; } = 5749;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_enabled;
        
        public virtual bool Enabled
        {
            get
            {
                return m_enabled;
            }
            set
            {
                m_enabled = value;
            }
        }
        
        public JobAllowMultiCraftRequestSetMessage(bool enabled)
        {
            m_enabled = enabled;
        }
        
        public JobAllowMultiCraftRequestSetMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_enabled);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_enabled = reader.ReadBoolean();
        }
    }
}
