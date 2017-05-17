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


    public class QuestObjectiveInformationsWithCompletion : QuestObjectiveInformations
    {
        
        public override int ProtocolId { get; } = 386;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_curCompletion;
        
        public virtual ushort CurCompletion
        {
            get
            {
                return m_curCompletion;
            }
            set
            {
                m_curCompletion = value;
            }
        }
        
        private ushort m_maxCompletion;
        
        public virtual ushort MaxCompletion
        {
            get
            {
                return m_maxCompletion;
            }
            set
            {
                m_maxCompletion = value;
            }
        }
        
        public QuestObjectiveInformationsWithCompletion(ushort curCompletion, ushort maxCompletion)
        {
            m_curCompletion = curCompletion;
            m_maxCompletion = maxCompletion;
        }
        
        public QuestObjectiveInformationsWithCompletion()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort(m_curCompletion);
            writer.WriteVarShort(m_maxCompletion);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_curCompletion = reader.ReadVarUhShort();
            m_maxCompletion = reader.ReadVarUhShort();
        }
    }
}
