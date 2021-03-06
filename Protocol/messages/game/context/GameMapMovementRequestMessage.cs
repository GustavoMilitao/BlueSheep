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
    using System.Collections.Generic;


    public class GameMapMovementRequestMessage : Message
    {
        
        public override int ProtocolId { get; } = 950;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Int16> m_keyMovements;
        
        public virtual List<System.Int16> KeyMovements
        {
            get
            {
                return m_keyMovements;
            }
            set
            {
                m_keyMovements = value;
            }
        }
        
        private int m_mapId;
        
        public virtual int MapId
        {
            get
            {
                return m_mapId;
            }
            set
            {
                m_mapId = value;
            }
        }
        
        public GameMapMovementRequestMessage(List<System.Int16> keyMovements, int mapId)
        {
            m_keyMovements = keyMovements;
            m_mapId = mapId;
        }
        
        public GameMapMovementRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_keyMovements.Count)));
            int keyMovementsIndex;
            for (keyMovementsIndex = 0; (keyMovementsIndex < m_keyMovements.Count); keyMovementsIndex = (keyMovementsIndex + 1))
            {
                writer.WriteShort(m_keyMovements[keyMovementsIndex]);
            }
            writer.WriteInt(m_mapId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int keyMovementsCount = reader.ReadUShort();
            int keyMovementsIndex;
            m_keyMovements = new System.Collections.Generic.List<short>();
            for (keyMovementsIndex = 0; (keyMovementsIndex < keyMovementsCount); keyMovementsIndex = (keyMovementsIndex + 1))
            {
                m_keyMovements.Add(reader.ReadShort());
            }
            m_mapId = reader.ReadInt();
        }
    }
}
