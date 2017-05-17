//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Dare
{
    using MageBot.Protocol.Types;


    public class DareReward : NetworkType
    {
        
        protected override int ProtocolId { get; set; } = 505;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
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
        
        private ushort m_monsterId;
        
        public virtual ushort MonsterId
        {
            get
            {
                return m_monsterId;
            }
            set
            {
                m_monsterId = value;
            }
        }
        
        private ulong m_kamas;
        
        public virtual ulong Kamas
        {
            get
            {
                return m_kamas;
            }
            set
            {
                m_kamas = value;
            }
        }
        
        private double m_dareId;
        
        public virtual double DareId
        {
            get
            {
                return m_dareId;
            }
            set
            {
                m_dareId = value;
            }
        }
        
        public DareReward(byte type, ushort monsterId, ulong kamas, double dareId)
        {
            m_type = type;
            m_monsterId = monsterId;
            m_kamas = kamas;
            m_dareId = dareId;
        }
        
        public DareReward()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_type);
            writer.WriteVarShort(m_monsterId);
            writer.WriteVarLong(m_kamas);
            writer.WriteDouble(m_dareId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_type = reader.ReadByte();
            m_monsterId = reader.ReadVarUhShort();
            m_kamas = reader.ReadVarUhLong();
            m_dareId = reader.ReadDouble();
        }
    }
}
