//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Roleplay.Quest
{
    using System.Collections.Generic;


    public class QuestActiveDetailedInformations : QuestActiveInformations
    {
        
        protected override int ProtocolId { get; set; } = 382;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<QuestObjectiveInformations> m_objectives;
        
        public virtual List<QuestObjectiveInformations> Objectives
        {
            get
            {
                return m_objectives;
            }
            set
            {
                m_objectives = value;
            }
        }
        
        private ushort m_stepId;
        
        public virtual ushort StepId
        {
            get
            {
                return m_stepId;
            }
            set
            {
                m_stepId = value;
            }
        }
        
        public QuestActiveDetailedInformations(List<QuestObjectiveInformations> objectives, ushort stepId)
        {
            m_objectives = objectives;
            m_stepId = stepId;
        }
        
        public QuestActiveDetailedInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_objectives.Count)));
            int objectivesIndex;
            for (objectivesIndex = 0; (objectivesIndex < m_objectives.Count); objectivesIndex = (objectivesIndex + 1))
            {
                QuestObjectiveInformations objectToSend = m_objectives[objectivesIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteVarShort(m_stepId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int objectivesCount = reader.ReadUShort();
            int objectivesIndex;
            m_objectives = new System.Collections.Generic.List<QuestObjectiveInformations>();
            for (objectivesIndex = 0; (objectivesIndex < objectivesCount); objectivesIndex = (objectivesIndex + 1))
            {
                QuestObjectiveInformations objectToAdd = ProtocolTypeManager.GetInstance<QuestObjectiveInformations>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_objectives.Add(objectToAdd);
            }
            m_stepId = reader.ReadVarUhShort();
        }
    }
}
