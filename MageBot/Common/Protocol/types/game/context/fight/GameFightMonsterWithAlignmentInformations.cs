//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context.Fight
{
    using BlueSheep.Common.Protocol.Types.Game.Character.Alignment;


    public class GameFightMonsterWithAlignmentInformations : GameFightMonsterInformations
    {
        
        public const int ProtocolId = 203;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ActorAlignmentInformations m_alignmentInfos;
        
        public virtual ActorAlignmentInformations AlignmentInfos
        {
            get
            {
                return m_alignmentInfos;
            }
            set
            {
                m_alignmentInfos = value;
            }
        }
        
        public GameFightMonsterWithAlignmentInformations(ActorAlignmentInformations alignmentInfos)
        {
            m_alignmentInfos = alignmentInfos;
        }
        
        public GameFightMonsterWithAlignmentInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_alignmentInfos.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_alignmentInfos = new ActorAlignmentInformations();
            m_alignmentInfos.Deserialize(reader);
        }
    }
}