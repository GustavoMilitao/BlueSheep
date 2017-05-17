//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Roleplay
{
    using MageBot.Protocol.Types.Game.Context;
    using System.Collections.Generic;
    using MageBot.Protocol.Types;


    public class AtlasPointsInformations : NetworkType
    {
        
        public override int ProtocolId { get; } = 175;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<MapCoordinatesExtended> m_coords;
        
        public virtual List<MapCoordinatesExtended> Coords
        {
            get
            {
                return m_coords;
            }
            set
            {
                m_coords = value;
            }
        }
        
        private byte m_type;
        
        public virtual byte Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
            }
        }
        
        public AtlasPointsInformations(List<MapCoordinatesExtended> coords, byte type)
        {
            m_coords = coords;
            m_type = type;
        }
        
        public AtlasPointsInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_coords.Count)));
            int coordsIndex;
            for (coordsIndex = 0; (coordsIndex < m_coords.Count); coordsIndex = (coordsIndex + 1))
            {
                MapCoordinatesExtended objectToSend = m_coords[coordsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteByte(m_type);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int coordsCount = reader.ReadUShort();
            int coordsIndex;
            m_coords = new System.Collections.Generic.List<MapCoordinatesExtended>();
            for (coordsIndex = 0; (coordsIndex < coordsCount); coordsIndex = (coordsIndex + 1))
            {
                MapCoordinatesExtended objectToAdd = new MapCoordinatesExtended();
                objectToAdd.Deserialize(reader);
                m_coords.Add(objectToAdd);
            }
            m_type = reader.ReadByte();
        }
    }
}
