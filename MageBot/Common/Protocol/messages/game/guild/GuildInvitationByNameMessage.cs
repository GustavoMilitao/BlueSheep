//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Guild
{
    using BlueSheep.Common;


    public class GuildInvitationByNameMessage : Message
    {
        
        public const int ProtocolId = 6115;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_name;
        
        public virtual string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }
        
        public GuildInvitationByNameMessage(string name)
        {
            m_name = name;
        }
        
        public GuildInvitationByNameMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_name);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_name = reader.ReadUTF();
        }
    }
}