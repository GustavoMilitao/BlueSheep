//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Atlas.Compass
{


    public class CompassUpdatePvpSeekMessage : CompassUpdateMessage
    {
        
        public override int ProtocolId { get; } = 6013;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_memberId;
        
        public virtual ulong MemberId
        {
            get
            {
                return m_memberId;
            }
            set
            {
                m_memberId = value;
            }
        }
        
        private string m_memberName;
        
        public virtual string MemberName
        {
            get
            {
                return m_memberName;
            }
            set
            {
                m_memberName = value;
            }
        }
        
        public CompassUpdatePvpSeekMessage(ulong memberId, string memberName)
        {
            m_memberId = memberId;
            m_memberName = memberName;
        }
        
        public CompassUpdatePvpSeekMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(m_memberId);
            writer.WriteUTF(m_memberName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_memberId = reader.ReadVarUhLong();
            m_memberName = reader.ReadUTF();
        }
    }
}
