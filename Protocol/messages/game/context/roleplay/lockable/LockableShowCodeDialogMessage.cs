//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Lockable
{
    public class LockableShowCodeDialogMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5740;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_changeOrUse;
        
        public virtual bool ChangeOrUse
        {
            get
            {
                return m_changeOrUse;
            }
            set
            {
                m_changeOrUse = value;
            }
        }
        
        private byte m_codeSize;
        
        public virtual byte CodeSize
        {
            get
            {
                return m_codeSize;
            }
            set
            {
                m_codeSize = value;
            }
        }
        
        public LockableShowCodeDialogMessage(bool changeOrUse, byte codeSize)
        {
            m_changeOrUse = changeOrUse;
            m_codeSize = codeSize;
        }
        
        public LockableShowCodeDialogMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_changeOrUse);
            writer.WriteByte(m_codeSize);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_changeOrUse = reader.ReadBoolean();
            m_codeSize = reader.ReadByte();
        }
    }
}
