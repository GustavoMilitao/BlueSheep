//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Paddock
{
    using MageBot.Protocol.Types.Game.Paddock;


    public class PaddockPropertiesMessage : Message
    {
        
        public override int ProtocolId { get; } = 5824;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private PaddockInstancesInformations m_properties;
        
        public virtual PaddockInstancesInformations Properties
        {
            get
            {
                return m_properties;
            }
            set
            {
                m_properties = value;
            }
        }
        
        public PaddockPropertiesMessage(PaddockInstancesInformations properties)
        {
            m_properties = properties;
        }
        
        public PaddockPropertiesMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_properties.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_properties = new PaddockInstancesInformations();
            m_properties.Deserialize(reader);
        }
    }
}
