//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Job
{
    using MageBot.Protocol.Types.Game.Context.Roleplay.Job;
    using System.Collections.Generic;


    public class JobCrafterDirectoryListMessage : Message
    {
        
        public override int ProtocolId { get; } = 6046;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<JobCrafterDirectoryListEntry> m_listEntries;
        
        public virtual List<JobCrafterDirectoryListEntry> ListEntries
        {
            get
            {
                return m_listEntries;
            }
            set
            {
                m_listEntries = value;
            }
        }
        
        public JobCrafterDirectoryListMessage(List<JobCrafterDirectoryListEntry> listEntries)
        {
            m_listEntries = listEntries;
        }
        
        public JobCrafterDirectoryListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_listEntries.Count)));
            int listEntriesIndex;
            for (listEntriesIndex = 0; (listEntriesIndex < m_listEntries.Count); listEntriesIndex = (listEntriesIndex + 1))
            {
                JobCrafterDirectoryListEntry objectToSend = m_listEntries[listEntriesIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int listEntriesCount = reader.ReadUShort();
            int listEntriesIndex;
            m_listEntries = new System.Collections.Generic.List<JobCrafterDirectoryListEntry>();
            for (listEntriesIndex = 0; (listEntriesIndex < listEntriesCount); listEntriesIndex = (listEntriesIndex + 1))
            {
                JobCrafterDirectoryListEntry objectToAdd = new JobCrafterDirectoryListEntry();
                objectToAdd.Deserialize(reader);
                m_listEntries.Add(objectToAdd);
            }
        }
    }
}
