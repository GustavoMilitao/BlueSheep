//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Prism
{
    public class PrismUseRequestMessage : Message
    {
        
        public override int ProtocolId { get; } = 6041;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_moduleToUse;
        
        public virtual byte ModuleToUse
        {
            get
            {
                return m_moduleToUse;
            }
            set
            {
                m_moduleToUse = value;
            }
        }
        
        public PrismUseRequestMessage(byte moduleToUse)
        {
            m_moduleToUse = moduleToUse;
        }
        
        public PrismUseRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_moduleToUse);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_moduleToUse = reader.ReadByte();
        }
    }
}
