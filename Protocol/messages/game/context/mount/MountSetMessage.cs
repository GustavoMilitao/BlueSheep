//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Mount
{
    using MageBot.Protocol.Types.Game.Mount;


    public class MountSetMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5968;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private MountClientData m_mountData;
        
        public virtual MountClientData MountData
        {
            get
            {
                return m_mountData;
            }
            set
            {
                m_mountData = value;
            }
        }
        
        public MountSetMessage(MountClientData mountData)
        {
            m_mountData = mountData;
        }
        
        public MountSetMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_mountData.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_mountData = new MountClientData();
            m_mountData.Deserialize(reader);
        }
    }
}
