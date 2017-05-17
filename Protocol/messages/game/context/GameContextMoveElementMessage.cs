//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context
{
    using MageBot.Protocol.Types.Game.Context;


    public class GameContextMoveElementMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 253;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private EntityMovementInformations m_movement;
        
        public virtual EntityMovementInformations Movement
        {
            get
            {
                return m_movement;
            }
            set
            {
                m_movement = value;
            }
        }
        
        public GameContextMoveElementMessage(EntityMovementInformations movement)
        {
            m_movement = movement;
        }
        
        public GameContextMoveElementMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_movement.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_movement = new EntityMovementInformations();
            m_movement.Deserialize(reader);
        }
    }
}
