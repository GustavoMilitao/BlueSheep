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
    using MageBot.Protocol.Types;
    using MageBot.Protocol.Types.Game.Context.Roleplay.Party;


    public class PartyUpdateMessage : AbstractPartyEventMessage
    {
        
        public override int ProtocolId { get; } = 5575;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private PartyMemberInformations m_memberInformations;
        
        public virtual PartyMemberInformations MemberInformations
        {
            get
            {
                return m_memberInformations;
            }
            set
            {
                m_memberInformations = value;
            }
        }
        
        public PartyUpdateMessage(PartyMemberInformations memberInformations)
        {
            m_memberInformations = memberInformations;
        }
        
        public PartyUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUShort(((ushort)(m_memberInformations.TypeID)));
            m_memberInformations.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_memberInformations = ProtocolTypeManager.GetInstance<PartyMemberInformations>(reader.ReadUShort());
            m_memberInformations.Deserialize(reader);
        }
    }
}
