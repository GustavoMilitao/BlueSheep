//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Npc
{
    public class NpcDialogReplyMessage : Message
    {
        
        public override int ProtocolId { get; } = 5616;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_replyId;
        
        public virtual uint ReplyId
        {
            get
            {
                return m_replyId;
            }
            set
            {
                m_replyId = value;
            }
        }
        
        public NpcDialogReplyMessage(uint replyId)
        {
            m_replyId = replyId;
        }
        
        public NpcDialogReplyMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_replyId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_replyId = reader.ReadVarUhInt();
        }
    }
}
