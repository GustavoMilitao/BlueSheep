//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Actions.Fight
{
    using MageBot.Protocol.Messages.Game.Actions;
    using MageBot.Protocol.Types.Game.Actions.Fight;


    public class GameActionFightMarkCellsMessage : AbstractGameActionMessage
    {
        
        public override int ProtocolId { get; } = 5540;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GameActionMark m_mark;
        
        public virtual GameActionMark Mark
        {
            get
            {
                return m_mark;
            }
            set
            {
                m_mark = value;
            }
        }
        
        public GameActionFightMarkCellsMessage(GameActionMark mark)
        {
            m_mark = mark;
        }
        
        public GameActionFightMarkCellsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_mark.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_mark = new GameActionMark();
            m_mark.Deserialize(reader);
        }
    }
}
