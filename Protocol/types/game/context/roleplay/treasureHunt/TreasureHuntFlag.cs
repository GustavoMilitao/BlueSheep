//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Roleplay.TreasureHunt
{
    using MageBot.Protocol.Types;


    public class TreasureHuntFlag : NetworkType
    {
        
        public override int ProtocolId { get; } = 473;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
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
        
        private byte m_state;
        
        public virtual byte State
        {
            get
            {
                return m_state;
            }
            set
            {
                m_state = value;
            }
        }
        
        public TreasureHuntFlag(int mapId, byte state)
        {
            m_mapId = mapId;
            m_state = state;
        }
        
        public TreasureHuntFlag()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_mapId);
            writer.WriteByte(m_state);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_mapId = reader.ReadInt();
            m_state = reader.ReadByte();
        }
    }
}
