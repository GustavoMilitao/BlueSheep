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


    public class JobExperienceUpdateMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5654;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private JobExperience m_experiencesUpdate;
        
        public virtual JobExperience ExperiencesUpdate
        {
            get
            {
                return m_experiencesUpdate;
            }
            set
            {
                m_experiencesUpdate = value;
            }
        }
        
        public JobExperienceUpdateMessage(JobExperience experiencesUpdate)
        {
            m_experiencesUpdate = experiencesUpdate;
        }
        
        public JobExperienceUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_experiencesUpdate.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_experiencesUpdate = new JobExperience();
            m_experiencesUpdate.Deserialize(reader);
        }
    }
}
