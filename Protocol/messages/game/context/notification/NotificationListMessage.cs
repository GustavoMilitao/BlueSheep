//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Notification
{
    using System.Collections.Generic;


    public class NotificationListMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6087;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Int32> m_flags;
        
        public virtual List<System.Int32> Flags
        {
            get
            {
                return m_flags;
            }
            set
            {
                m_flags = value;
            }
        }
        
        public NotificationListMessage(List<System.Int32> flags)
        {
            m_flags = flags;
        }
        
        public NotificationListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_flags.Count)));
            int flagsIndex;
            for (flagsIndex = 0; (flagsIndex < m_flags.Count); flagsIndex = (flagsIndex + 1))
            {
                writer.WriteVarInt(m_flags[flagsIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int flagsCount = reader.ReadUShort();
            int flagsIndex;
            m_flags = new System.Collections.Generic.List<int>();
            for (flagsIndex = 0; (flagsIndex < flagsCount); flagsIndex = (flagsIndex + 1))
            {
                m_flags.Add(reader.ReadVarInt());
            }
        }
    }
}
