//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Document
{
    public class ComicReadingBeginMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6536;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_comicId;
        
        public virtual ushort ComicId
        {
            get
            {
                return m_comicId;
            }
            set
            {
                m_comicId = value;
            }
        }
        
        public ComicReadingBeginMessage(ushort comicId)
        {
            m_comicId = comicId;
        }
        
        public ComicReadingBeginMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_comicId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_comicId = reader.ReadVarUhShort();
        }
    }
}
