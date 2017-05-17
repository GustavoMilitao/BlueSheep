//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Party
{


    public class PartyInvitationDungeonMessage : PartyInvitationMessage
    {
        
        protected override int ProtocolId { get; set; } = 6244;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_dungeonId;
        
        public virtual ushort DungeonId
        {
            get
            {
                return m_dungeonId;
            }
            set
            {
                m_dungeonId = value;
            }
        }
        
        public PartyInvitationDungeonMessage(ushort dungeonId)
        {
            m_dungeonId = dungeonId;
        }
        
        public PartyInvitationDungeonMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort(m_dungeonId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_dungeonId = reader.ReadVarUhShort();
        }
    }
}
