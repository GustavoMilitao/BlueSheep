//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Fight
{


    public class FightResultPvpData : FightResultAdditionalData
    {
        
        public override int ProtocolId { get; } = 190;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_grade;
        
        public virtual sbyte Grade
        {
            get
            {
                return m_grade;
            }
            set
            {
                m_grade = value;
            }
        }
        
        private ushort m_minHonorForGrade;
        
        public virtual ushort MinHonorForGrade
        {
            get
            {
                return m_minHonorForGrade;
            }
            set
            {
                m_minHonorForGrade = value;
            }
        }
        
        private ushort m_maxHonorForGrade;
        
        public virtual ushort MaxHonorForGrade
        {
            get
            {
                return m_maxHonorForGrade;
            }
            set
            {
                m_maxHonorForGrade = value;
            }
        }
        
        private ushort m_honor;
        
        public virtual ushort Honor
        {
            get
            {
                return m_honor;
            }
            set
            {
                m_honor = value;
            }
        }
        
        private short m_honorDelta;
        
        public virtual short HonorDelta
        {
            get
            {
                return m_honorDelta;
            }
            set
            {
                m_honorDelta = value;
            }
        }
        
        public FightResultPvpData(sbyte grade, ushort minHonorForGrade, ushort maxHonorForGrade, ushort honor, short honorDelta)
        {
            m_grade = grade;
            m_minHonorForGrade = minHonorForGrade;
            m_maxHonorForGrade = maxHonorForGrade;
            m_honor = honor;
            m_honorDelta = honorDelta;
        }
        
        public FightResultPvpData()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(m_grade);
            writer.WriteVarShort(m_minHonorForGrade);
            writer.WriteVarShort(m_maxHonorForGrade);
            writer.WriteVarShort(m_honor);
            writer.WriteVarShort(m_honorDelta);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_grade = reader.ReadSByte();
            m_minHonorForGrade = reader.ReadVarUhShort();
            m_maxHonorForGrade = reader.ReadVarUhShort();
            m_honor = reader.ReadVarUhShort();
            m_honorDelta = reader.ReadVarShort();
        }
    }
}
