//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    using System.Collections.Generic;


    public class TreasureHuntShowLegendaryUIMessage : Message
    {
        
        public override int ProtocolId { get; } = 6498;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_availableLegendaryIds;
        
        public virtual List<System.UInt16> AvailableLegendaryIds
        {
            get
            {
                return m_availableLegendaryIds;
            }
            set
            {
                m_availableLegendaryIds = value;
            }
        }
        
        public TreasureHuntShowLegendaryUIMessage(List<System.UInt16> availableLegendaryIds)
        {
            m_availableLegendaryIds = availableLegendaryIds;
        }
        
        public TreasureHuntShowLegendaryUIMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_availableLegendaryIds.Count)));
            int availableLegendaryIdsIndex;
            for (availableLegendaryIdsIndex = 0; (availableLegendaryIdsIndex < m_availableLegendaryIds.Count); availableLegendaryIdsIndex = (availableLegendaryIdsIndex + 1))
            {
                writer.WriteVarShort(m_availableLegendaryIds[availableLegendaryIdsIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int availableLegendaryIdsCount = reader.ReadUShort();
            int availableLegendaryIdsIndex;
            m_availableLegendaryIds = new System.Collections.Generic.List<ushort>();
            for (availableLegendaryIdsIndex = 0; (availableLegendaryIdsIndex < availableLegendaryIdsCount); availableLegendaryIdsIndex = (availableLegendaryIdsIndex + 1))
            {
                m_availableLegendaryIds.Add(reader.ReadVarUhShort());
            }
        }
    }
}
