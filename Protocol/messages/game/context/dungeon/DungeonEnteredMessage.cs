//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Dungeon
{
    public class DungeonEnteredMessage : Message
    {
        
        public override int ProtocolId { get; } = 6152;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_dungeonId;
        
        public virtual int DungeonId
        {
            get
            {
                return m_dungeonId;
            }
            set
            {
                m_dungeonId = value;
            }
        }
        
        public DungeonEnteredMessage(int dungeonId)
        {
            m_dungeonId = dungeonId;
        }
        
        public DungeonEnteredMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_dungeonId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_dungeonId = reader.ReadInt();
        }
    }
}
