//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay
{
    public class MapFightCountMessage : Message
    {
        
        public override int ProtocolId { get; } = 210;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_fightCount;
        
        public virtual ushort FightCount
        {
            get
            {
                return m_fightCount;
            }
            set
            {
                m_fightCount = value;
            }
        }
        
        public MapFightCountMessage(ushort fightCount)
        {
            m_fightCount = fightCount;
        }
        
        public MapFightCountMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_fightCount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_fightCount = reader.ReadVarUhShort();
        }
    }
}
