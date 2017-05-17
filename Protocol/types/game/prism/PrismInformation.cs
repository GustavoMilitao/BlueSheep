//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Prism
{
    using MageBot.Protocol.Types;


    public class PrismInformation : NetworkType
    {
        
        public override int ProtocolId { get; } = 428;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_typeId;
        
        public virtual byte TypeId
        {
            get
            {
                return m_typeId;
            }
            set
            {
                m_typeId = value;
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
        
        private int m_nextVulnerabilityDate;
        
        public virtual int NextVulnerabilityDate
        {
            get
            {
                return m_nextVulnerabilityDate;
            }
            set
            {
                m_nextVulnerabilityDate = value;
            }
        }
        
        private int m_placementDate;
        
        public virtual int PlacementDate
        {
            get
            {
                return m_placementDate;
            }
            set
            {
                m_placementDate = value;
            }
        }
        
        private uint m_rewardTokenCount;
        
        public virtual uint RewardTokenCount
        {
            get
            {
                return m_rewardTokenCount;
            }
            set
            {
                m_rewardTokenCount = value;
            }
        }
        
        public PrismInformation(byte typeId, byte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount)
        {
            m_typeId = typeId;
            m_state = state;
            m_nextVulnerabilityDate = nextVulnerabilityDate;
            m_placementDate = placementDate;
            m_rewardTokenCount = rewardTokenCount;
        }
        
        public PrismInformation()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_typeId);
            writer.WriteByte(m_state);
            writer.WriteInt(m_nextVulnerabilityDate);
            writer.WriteInt(m_placementDate);
            writer.WriteVarInt(m_rewardTokenCount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_typeId = reader.ReadByte();
            m_state = reader.ReadByte();
            m_nextVulnerabilityDate = reader.ReadInt();
            m_placementDate = reader.ReadInt();
            m_rewardTokenCount = reader.ReadVarUhInt();
        }
    }
}
