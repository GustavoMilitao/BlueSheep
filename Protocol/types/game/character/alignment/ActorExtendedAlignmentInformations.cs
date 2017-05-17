//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Character.Alignment
{


    public class ActorExtendedAlignmentInformations : ActorAlignmentInformations
    {
        
        protected override int ProtocolId { get; set; } = 202;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
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
        
        private ushort m_honorGradeFloor;
        
        public virtual ushort HonorGradeFloor
        {
            get
            {
                return m_honorGradeFloor;
            }
            set
            {
                m_honorGradeFloor = value;
            }
        }
        
        private ushort m_honorNextGradeFloor;
        
        public virtual ushort HonorNextGradeFloor
        {
            get
            {
                return m_honorNextGradeFloor;
            }
            set
            {
                m_honorNextGradeFloor = value;
            }
        }
        
        private byte m_aggressable;
        
        public virtual byte Aggressable
        {
            get
            {
                return m_aggressable;
            }
            set
            {
                m_aggressable = value;
            }
        }
        
        public ActorExtendedAlignmentInformations(ushort honor, ushort honorGradeFloor, ushort honorNextGradeFloor, byte aggressable)
        {
            m_honor = honor;
            m_honorGradeFloor = honorGradeFloor;
            m_honorNextGradeFloor = honorNextGradeFloor;
            m_aggressable = aggressable;
        }
        
        public ActorExtendedAlignmentInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort(m_honor);
            writer.WriteVarShort(m_honorGradeFloor);
            writer.WriteVarShort(m_honorNextGradeFloor);
            writer.WriteByte(m_aggressable);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_honor = reader.ReadVarUhShort();
            m_honorGradeFloor = reader.ReadVarUhShort();
            m_honorNextGradeFloor = reader.ReadVarUhShort();
            m_aggressable = reader.ReadByte();
        }
    }
}
