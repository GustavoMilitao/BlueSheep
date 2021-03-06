//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Havenbag
{
    using BlueSheep.Common;


    public class ChangeHavenBagRoomRequestMessage : Message
    {
        
        public const int ProtocolId = 6638;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_roomId;
        
        public virtual byte RoomId
        {
            get
            {
                return m_roomId;
            }
            set
            {
                m_roomId = value;
            }
        }
        
        public ChangeHavenBagRoomRequestMessage(byte roomId)
        {
            m_roomId = roomId;
        }
        
        public ChangeHavenBagRoomRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_roomId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_roomId = reader.ReadByte();
        }
    }
}
