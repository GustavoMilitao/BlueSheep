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
    using MageBot.Protocol.Types.Game.Look;


    public class AccessoryPreviewMessage : Message
    {
        
        public override int ProtocolId { get; } = 6517;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private EntityLook m_look;
        
        public virtual EntityLook Look
        {
            get
            {
                return m_look;
            }
            set
            {
                m_look = value;
            }
        }
        
        public AccessoryPreviewMessage(EntityLook look)
        {
            m_look = look;
        }
        
        public AccessoryPreviewMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_look.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_look = new EntityLook();
            m_look.Deserialize(reader);
        }
    }
}
