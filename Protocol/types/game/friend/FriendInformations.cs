//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Friend
{


    public class FriendInformations : AbstractContactInformations
    {
        
        protected override int ProtocolId { get; set; } = 78;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_playerState;
        
        public virtual byte PlayerState
        {
            get
            {
                return m_playerState;
            }
            set
            {
                m_playerState = value;
            }
        }
        
        private ushort m_lastConnection;
        
        public virtual ushort LastConnection
        {
            get
            {
                return m_lastConnection;
            }
            set
            {
                m_lastConnection = value;
            }
        }
        
        private int m_achievementPoints;
        
        public virtual int AchievementPoints
        {
            get
            {
                return m_achievementPoints;
            }
            set
            {
                m_achievementPoints = value;
            }
        }
        
        public FriendInformations(byte playerState, ushort lastConnection, int achievementPoints)
        {
            m_playerState = playerState;
            m_lastConnection = lastConnection;
            m_achievementPoints = achievementPoints;
        }
        
        public FriendInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_playerState);
            writer.WriteVarShort(m_lastConnection);
            writer.WriteInt(m_achievementPoints);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_playerState = reader.ReadByte();
            m_lastConnection = reader.ReadVarUhShort();
            m_achievementPoints = reader.ReadInt();
        }
    }
}
