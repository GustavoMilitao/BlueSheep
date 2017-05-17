//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Interactive
{
    using MageBot.Protocol.Types;


    public class InteractiveElementSkill : NetworkType
    {
        
        protected override int ProtocolId { get; set; } = 219;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_skillId;
        
        public virtual uint SkillId
        {
            get
            {
                return m_skillId;
            }
            set
            {
                m_skillId = value;
            }
        }
        
        private int m_skillInstanceUid;
        
        public virtual int SkillInstanceUid
        {
            get
            {
                return m_skillInstanceUid;
            }
            set
            {
                m_skillInstanceUid = value;
            }
        }
        
        public InteractiveElementSkill(uint skillId, int skillInstanceUid)
        {
            m_skillId = skillId;
            m_skillInstanceUid = skillInstanceUid;
        }
        
        public InteractiveElementSkill()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_skillId);
            writer.WriteInt(m_skillInstanceUid);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_skillId = reader.ReadVarUhInt();
            m_skillInstanceUid = reader.ReadInt();
        }
    }
}
