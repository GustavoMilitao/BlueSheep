//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Npc
{
    using MageBot.Protocol.Types.Game.Context.Roleplay;


    public class AllianceTaxCollectorDialogQuestionExtendedMessage : TaxCollectorDialogQuestionExtendedMessage
    {
        
        protected override int ProtocolId { get; set; } = 6445;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private BasicNamedAllianceInformations m_alliance;
        
        public virtual BasicNamedAllianceInformations Alliance
        {
            get
            {
                return m_alliance;
            }
            set
            {
                m_alliance = value;
            }
        }
        
        public AllianceTaxCollectorDialogQuestionExtendedMessage(BasicNamedAllianceInformations alliance)
        {
            m_alliance = alliance;
        }
        
        public AllianceTaxCollectorDialogQuestionExtendedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_alliance.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_alliance = new BasicNamedAllianceInformations();
            m_alliance.Deserialize(reader);
        }
    }
}
