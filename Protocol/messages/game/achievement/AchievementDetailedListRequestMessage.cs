//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Achievement
{
    public class AchievementDetailedListRequestMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6357;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_categoryId;
        
        public virtual ushort CategoryId
        {
            get
            {
                return m_categoryId;
            }
            set
            {
                m_categoryId = value;
            }
        }
        
        public AchievementDetailedListRequestMessage(ushort categoryId)
        {
            m_categoryId = categoryId;
        }
        
        public AchievementDetailedListRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_categoryId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_categoryId = reader.ReadVarUhShort();
        }
    }
}
