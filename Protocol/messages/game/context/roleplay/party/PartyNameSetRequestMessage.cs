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


    public class PartyNameSetRequestMessage : AbstractPartyMessage
    {
        
        public override int ProtocolId { get; } = 6503;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_partyName;
        
        public virtual string PartyName
        {
            get
            {
                return m_partyName;
            }
            set
            {
                m_partyName = value;
            }
        }
        
        public PartyNameSetRequestMessage(string partyName)
        {
            m_partyName = partyName;
        }
        
        public PartyNameSetRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_partyName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_partyName = reader.ReadUTF();
        }
    }
}
