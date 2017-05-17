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


    public class PartyMemberRemoveMessage : AbstractPartyEventMessage
    {
        
        public override int ProtocolId { get; } = 5579;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_leavingPlayerId;
        
        public virtual ulong LeavingPlayerId
        {
            get
            {
                return m_leavingPlayerId;
            }
            set
            {
                m_leavingPlayerId = value;
            }
        }
        
        public PartyMemberRemoveMessage(ulong leavingPlayerId)
        {
            m_leavingPlayerId = leavingPlayerId;
        }
        
        public PartyMemberRemoveMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(m_leavingPlayerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_leavingPlayerId = reader.ReadVarUhLong();
        }
    }
}
