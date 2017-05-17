//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Alliance
{
    using MageBot.Protocol.Types.Game.Social;
    using System.Collections.Generic;


    public class AllianceVersatileInfoListMessage : Message
    {
        
        public override int ProtocolId { get; } = 6436;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<AllianceVersatileInformations> m_alliances;
        
        public virtual List<AllianceVersatileInformations> Alliances
        {
            get
            {
                return m_alliances;
            }
            set
            {
                m_alliances = value;
            }
        }
        
        public AllianceVersatileInfoListMessage(List<AllianceVersatileInformations> alliances)
        {
            m_alliances = alliances;
        }
        
        public AllianceVersatileInfoListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_alliances.Count)));
            int alliancesIndex;
            for (alliancesIndex = 0; (alliancesIndex < m_alliances.Count); alliancesIndex = (alliancesIndex + 1))
            {
                AllianceVersatileInformations objectToSend = m_alliances[alliancesIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int alliancesCount = reader.ReadUShort();
            int alliancesIndex;
            m_alliances = new System.Collections.Generic.List<AllianceVersatileInformations>();
            for (alliancesIndex = 0; (alliancesIndex < alliancesCount); alliancesIndex = (alliancesIndex + 1))
            {
                AllianceVersatileInformations objectToAdd = new AllianceVersatileInformations();
                objectToAdd.Deserialize(reader);
                m_alliances.Add(objectToAdd);
            }
        }
    }
}
