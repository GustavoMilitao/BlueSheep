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
    using System.Collections.Generic;
    using MageBot.Protocol.Types;


    public class InteractiveElement : NetworkType
    {
        
        public override int ProtocolId { get; } = 80;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<InteractiveElementSkill> m_enabledSkills;
        
        public virtual List<InteractiveElementSkill> EnabledSkills
        {
            get
            {
                return m_enabledSkills;
            }
            set
            {
                m_enabledSkills = value;
            }
        }
        
        private List<InteractiveElementSkill> m_disabledSkills;
        
        public virtual List<InteractiveElementSkill> DisabledSkills
        {
            get
            {
                return m_disabledSkills;
            }
            set
            {
                m_disabledSkills = value;
            }
        }
        
        private int m_elementId;
        
        public virtual int ElementId
        {
            get
            {
                return m_elementId;
            }
            set
            {
                m_elementId = value;
            }
        }
        
        private int m_elementTypeId;
        
        public virtual int ElementTypeId
        {
            get
            {
                return m_elementTypeId;
            }
            set
            {
                m_elementTypeId = value;
            }
        }
        
        private bool m_onCurrentMap;
        
        public virtual bool OnCurrentMap
        {
            get
            {
                return m_onCurrentMap;
            }
            set
            {
                m_onCurrentMap = value;
            }
        }
        
        public InteractiveElement(List<InteractiveElementSkill> enabledSkills, List<InteractiveElementSkill> disabledSkills, int elementId, int elementTypeId, bool onCurrentMap)
        {
            m_enabledSkills = enabledSkills;
            m_disabledSkills = disabledSkills;
            m_elementId = elementId;
            m_elementTypeId = elementTypeId;
            m_onCurrentMap = onCurrentMap;
        }
        
        public InteractiveElement()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_enabledSkills.Count)));
            int enabledSkillsIndex;
            for (enabledSkillsIndex = 0; (enabledSkillsIndex < m_enabledSkills.Count); enabledSkillsIndex = (enabledSkillsIndex + 1))
            {
                InteractiveElementSkill objectToSend = m_enabledSkills[enabledSkillsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_disabledSkills.Count)));
            int disabledSkillsIndex;
            for (disabledSkillsIndex = 0; (disabledSkillsIndex < m_disabledSkills.Count); disabledSkillsIndex = (disabledSkillsIndex + 1))
            {
                InteractiveElementSkill objectToSend = m_disabledSkills[disabledSkillsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteInt(m_elementId);
            writer.WriteInt(m_elementTypeId);
            writer.WriteBoolean(m_onCurrentMap);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_elementId = reader.ReadInt();
            m_elementTypeId = reader.ReadInt();
            int enabledSkillsCount = reader.ReadUShort();
            int enabledSkillsIndex;
            m_enabledSkills = new System.Collections.Generic.List<InteractiveElementSkill>();
            for (enabledSkillsIndex = 0; (enabledSkillsIndex < enabledSkillsCount); enabledSkillsIndex = (enabledSkillsIndex + 1))
            {
                InteractiveElementSkill objectToAdd = ProtocolTypeManager.GetInstance<InteractiveElementSkill>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_enabledSkills.Add(objectToAdd);
            }
            int disabledSkillsCount = reader.ReadUShort();
            int disabledSkillsIndex;
            m_disabledSkills = new System.Collections.Generic.List<InteractiveElementSkill>();
            for (disabledSkillsIndex = 0; (disabledSkillsIndex < disabledSkillsCount); disabledSkillsIndex = (disabledSkillsIndex + 1))
            {
                InteractiveElementSkill objectToAdd = ProtocolTypeManager.GetInstance<InteractiveElementSkill>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_disabledSkills.Add(objectToAdd);
            }
            m_onCurrentMap = reader.ReadBoolean();
        }
    }
}
