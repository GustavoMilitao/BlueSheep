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
    using MageBot.Protocol.Types.Game.Friend;
    using MageBot.Protocol.Types;


    public class IgnoredAddedMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5678;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private IgnoredInformations m_ignoreAdded;
        
        public virtual IgnoredInformations IgnoreAdded
        {
            get
            {
                return m_ignoreAdded;
            }
            set
            {
                m_ignoreAdded = value;
            }
        }
        
        private bool m_session;
        
        public virtual bool Session
        {
            get
            {
                return m_session;
            }
            set
            {
                m_session = value;
            }
        }
        
        public IgnoredAddedMessage(IgnoredInformations ignoreAdded, bool session)
        {
            m_ignoreAdded = ignoreAdded;
            m_session = session;
        }
        
        public IgnoredAddedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(((ushort)(m_ignoreAdded.TypeID)));
            m_ignoreAdded.Serialize(writer);
            writer.WriteBoolean(m_session);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_ignoreAdded = ProtocolTypeManager.GetInstance<IgnoredInformations>(reader.ReadUShort());
            m_ignoreAdded.Deserialize(reader);
            m_session = reader.ReadBoolean();
        }
    }
}
