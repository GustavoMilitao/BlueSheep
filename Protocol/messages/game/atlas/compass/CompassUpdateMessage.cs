//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Atlas.Compass
{
    using MageBot.Protocol.Types.Game.Context;
    using MageBot.Protocol.Types;


    public class CompassUpdateMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5591;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private MapCoordinates m_coords;
        
        public virtual MapCoordinates Coords
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
        
        public CompassUpdateMessage(MapCoordinates coords, byte type)
        {
            m_coords = coords;
            m_type = type;
        }
        
        public CompassUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(((ushort)(m_coords.TypeID)));
            m_coords.Serialize(writer);
            writer.WriteByte(m_type);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_coords = ProtocolTypeManager.GetInstance<MapCoordinates>(reader.ReadUShort());
            m_coords.Deserialize(reader);
            m_type = reader.ReadByte();
        }
    }
}
