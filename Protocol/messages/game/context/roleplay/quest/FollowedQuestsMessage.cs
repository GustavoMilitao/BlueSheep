//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Quest
{
    using MageBot.Protocol.Types.Game.Context.Roleplay.Quest;
    using System.Collections.Generic;


    public class FollowedQuestsMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6717;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<QuestActiveDetailedInformations> m_quests;
        
        public virtual List<QuestActiveDetailedInformations> Quests
        {
            get
            {
                return m_quests;
            }
            set
            {
                m_quests = value;
            }
        }
        
        public FollowedQuestsMessage(List<QuestActiveDetailedInformations> quests)
        {
            m_quests = quests;
        }
        
        public FollowedQuestsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_quests.Count)));
            int questsIndex;
            for (questsIndex = 0; (questsIndex < m_quests.Count); questsIndex = (questsIndex + 1))
            {
                QuestActiveDetailedInformations objectToSend = m_quests[questsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int questsCount = reader.ReadUShort();
            int questsIndex;
            m_quests = new System.Collections.Generic.List<QuestActiveDetailedInformations>();
            for (questsIndex = 0; (questsIndex < questsCount); questsIndex = (questsIndex + 1))
            {
                QuestActiveDetailedInformations objectToAdd = new QuestActiveDetailedInformations();
                objectToAdd.Deserialize(reader);
                m_quests.Add(objectToAdd);
            }
        }
    }
}
