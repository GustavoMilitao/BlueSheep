//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Houses
{
    public class HouseToSellFilterMessage : Message
    {
        
        public override int ProtocolId { get; } = 6137;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_areaId;
        
        public virtual int AreaId
        {
            get
            {
                return m_areaId;
            }
            set
            {
                m_areaId = value;
            }
        }
        
        private byte m_atLeastNbRoom;
        
        public virtual byte AtLeastNbRoom
        {
            get
            {
                return m_atLeastNbRoom;
            }
            set
            {
                m_atLeastNbRoom = value;
            }
        }
        
        private byte m_atLeastNbChest;
        
        public virtual byte AtLeastNbChest
        {
            get
            {
                return m_atLeastNbChest;
            }
            set
            {
                m_atLeastNbChest = value;
            }
        }
        
        private ushort m_skillRequested;
        
        public virtual ushort SkillRequested
        {
            get
            {
                return m_skillRequested;
            }
            set
            {
                m_skillRequested = value;
            }
        }
        
        private ulong m_maxPrice;
        
        public virtual ulong MaxPrice
        {
            get
            {
                return m_maxPrice;
            }
            set
            {
                m_maxPrice = value;
            }
        }
        
        public HouseToSellFilterMessage(int areaId, byte atLeastNbRoom, byte atLeastNbChest, ushort skillRequested, ulong maxPrice)
        {
            m_areaId = areaId;
            m_atLeastNbRoom = atLeastNbRoom;
            m_atLeastNbChest = atLeastNbChest;
            m_skillRequested = skillRequested;
            m_maxPrice = maxPrice;
        }
        
        public HouseToSellFilterMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_areaId);
            writer.WriteByte(m_atLeastNbRoom);
            writer.WriteByte(m_atLeastNbChest);
            writer.WriteVarShort(m_skillRequested);
            writer.WriteVarLong(m_maxPrice);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_areaId = reader.ReadInt();
            m_atLeastNbRoom = reader.ReadByte();
            m_atLeastNbChest = reader.ReadByte();
            m_skillRequested = reader.ReadVarUhShort();
            m_maxPrice = reader.ReadVarUhLong();
        }
    }
}
