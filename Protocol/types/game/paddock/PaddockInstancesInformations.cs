//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Paddock
{
    using System.Collections.Generic;


    public class PaddockInstancesInformations : PaddockInformations
    {
        
        protected override int ProtocolId { get; set; } = 509;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<PaddockBuyableInformations> m_paddocks;
        
        public virtual List<PaddockBuyableInformations> Paddocks
        {
            get
            {
                return m_paddocks;
            }
            set
            {
                m_paddocks = value;
            }
        }
        
        public PaddockInstancesInformations(List<PaddockBuyableInformations> paddocks)
        {
            m_paddocks = paddocks;
        }
        
        public PaddockInstancesInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_paddocks.Count)));
            int paddocksIndex;
            for (paddocksIndex = 0; (paddocksIndex < m_paddocks.Count); paddocksIndex = (paddocksIndex + 1))
            {
                PaddockBuyableInformations objectToSend = m_paddocks[paddocksIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int paddocksCount = reader.ReadUShort();
            int paddocksIndex;
            m_paddocks = new System.Collections.Generic.List<PaddockBuyableInformations>();
            for (paddocksIndex = 0; (paddocksIndex < paddocksCount); paddocksIndex = (paddocksIndex + 1))
            {
                PaddockBuyableInformations objectToAdd = ProtocolTypeManager.GetInstance<PaddockBuyableInformations>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_paddocks.Add(objectToAdd);
            }
        }
    }
}
