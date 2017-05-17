//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Inventory
{
    using System.Collections.Generic;


    public class ObjectAveragePricesMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6335;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_ids;
        
        public virtual List<System.UInt16> Ids
        {
            get
            {
                return m_ids;
            }
            set
            {
                m_ids = value;
            }
        }
        
        private List<System.UInt64> m_avgPrices;
        
        public virtual List<System.UInt64> AvgPrices
        {
            get
            {
                return m_avgPrices;
            }
            set
            {
                m_avgPrices = value;
            }
        }
        
        public ObjectAveragePricesMessage(List<System.UInt16> ids, List<System.UInt64> avgPrices)
        {
            m_ids = ids;
            m_avgPrices = avgPrices;
        }
        
        public ObjectAveragePricesMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_ids.Count)));
            int idsIndex;
            for (idsIndex = 0; (idsIndex < m_ids.Count); idsIndex = (idsIndex + 1))
            {
                writer.WriteVarShort(m_ids[idsIndex]);
            }
            writer.WriteShort(((short)(m_avgPrices.Count)));
            int avgPricesIndex;
            for (avgPricesIndex = 0; (avgPricesIndex < m_avgPrices.Count); avgPricesIndex = (avgPricesIndex + 1))
            {
                writer.WriteVarLong(m_avgPrices[avgPricesIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int idsCount = reader.ReadUShort();
            int idsIndex;
            m_ids = new System.Collections.Generic.List<ushort>();
            for (idsIndex = 0; (idsIndex < idsCount); idsIndex = (idsIndex + 1))
            {
                m_ids.Add(reader.ReadVarUhShort());
            }
            int avgPricesCount = reader.ReadUShort();
            int avgPricesIndex;
            m_avgPrices = new System.Collections.Generic.List<ulong>();
            for (avgPricesIndex = 0; (avgPricesIndex < avgPricesCount); avgPricesIndex = (avgPricesIndex + 1))
            {
                m_avgPrices.Add(reader.ReadVarUhLong());
            }
        }
    }
}
