//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Idol
{
    using MageBot.Protocol.Types.Game.Idol;


    public class IdolPartyRefreshMessage : Message
    {
        
        public override int ProtocolId { get; } = 6583;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private PartyIdol m_partyIdol;
        
        public virtual PartyIdol PartyIdol
        {
            get
            {
                return m_partyIdol;
            }
            set
            {
                m_partyIdol = value;
            }
        }
        
        public IdolPartyRefreshMessage(PartyIdol partyIdol)
        {
            m_partyIdol = partyIdol;
        }
        
        public IdolPartyRefreshMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_partyIdol.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_partyIdol = new PartyIdol();
            m_partyIdol.Deserialize(reader);
        }
    }
}
