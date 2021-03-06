//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Friend
{
    using BlueSheep.Common;


    public class FriendDeleteRequestMessage : Message
    {
        
        public const int ProtocolId = 5603;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_accountId;
        
        public virtual int AccountId
        {
            get
            {
                return m_accountId;
            }
            set
            {
                m_accountId = value;
            }
        }
        
        public FriendDeleteRequestMessage(int accountId)
        {
            m_accountId = accountId;
        }
        
        public FriendDeleteRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_accountId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_accountId = reader.ReadInt();
        }
    }
}
