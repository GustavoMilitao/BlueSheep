//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Data.Items
{
    using System.Collections.Generic;
    using MageBot.Protocol.Types;


    public class SellerBuyerDescriptor : NetworkType
    {
        
        protected override int ProtocolId { get; set; } = 121;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt32> m_quantities;
        
        public virtual List<System.UInt32> Quantities
        {
            get
            {
                return m_quantities;
            }
            set
            {
                m_quantities = value;
            }
        }
        
        private List<System.UInt32> m_types;
        
        public virtual List<System.UInt32> Types
        {
            get
            {
                return m_types;
            }
            set
            {
                m_types = value;
            }
        }
        
        private float m_taxPercentage;
        
        public virtual float TaxPercentage
        {
            get
            {
                return m_taxPercentage;
            }
            set
            {
                m_taxPercentage = value;
            }
        }
        
        private float m_taxModificationPercentage;
        
        public virtual float TaxModificationPercentage
        {
            get
            {
                return m_taxModificationPercentage;
            }
            set
            {
                m_taxModificationPercentage = value;
            }
        }
        
        private sbyte m_maxItemLevel;
        
        public virtual sbyte MaxItemLevel
        {
            get
            {
                return m_maxItemLevel;
            }
            set
            {
                m_maxItemLevel = value;
            }
        }
        
        private uint m_maxItemPerAccount;
        
        public virtual uint MaxItemPerAccount
        {
            get
            {
                return m_maxItemPerAccount;
            }
            set
            {
                m_maxItemPerAccount = value;
            }
        }
        
        private int m_npcContextualId;
        
        public virtual int NpcContextualId
        {
            get
            {
                return m_npcContextualId;
            }
            set
            {
                m_npcContextualId = value;
            }
        }
        
        private ushort m_unsoldDelay;
        
        public virtual ushort UnsoldDelay
        {
            get
            {
                return m_unsoldDelay;
            }
            set
            {
                m_unsoldDelay = value;
            }
        }
        
        public SellerBuyerDescriptor(List<System.UInt32> quantities, List<System.UInt32> types, float taxPercentage, float taxModificationPercentage, sbyte maxItemLevel, uint maxItemPerAccount, int npcContextualId, ushort unsoldDelay)
        {
            m_quantities = quantities;
            m_types = types;
            m_taxPercentage = taxPercentage;
            m_taxModificationPercentage = taxModificationPercentage;
            m_maxItemLevel = maxItemLevel;
            m_maxItemPerAccount = maxItemPerAccount;
            m_npcContextualId = npcContextualId;
            m_unsoldDelay = unsoldDelay;
        }
        
        public SellerBuyerDescriptor()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_quantities.Count)));
            int quantitiesIndex;
            for (quantitiesIndex = 0; (quantitiesIndex < m_quantities.Count); quantitiesIndex = (quantitiesIndex + 1))
            {
                writer.WriteVarInt(m_quantities[quantitiesIndex]);
            }
            writer.WriteShort(((short)(m_types.Count)));
            int typesIndex;
            for (typesIndex = 0; (typesIndex < m_types.Count); typesIndex = (typesIndex + 1))
            {
                writer.WriteVarInt(m_types[typesIndex]);
            }
            writer.WriteFloat(m_taxPercentage);
            writer.WriteFloat(m_taxModificationPercentage);
            writer.WriteSByte(m_maxItemLevel);
            writer.WriteVarInt(m_maxItemPerAccount);
            writer.WriteInt(m_npcContextualId);
            writer.WriteVarShort(m_unsoldDelay);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int quantitiesCount = reader.ReadUShort();
            int quantitiesIndex;
            m_quantities = new System.Collections.Generic.List<uint>();
            for (quantitiesIndex = 0; (quantitiesIndex < quantitiesCount); quantitiesIndex = (quantitiesIndex + 1))
            {
                m_quantities.Add(reader.ReadVarUhInt());
            }
            int typesCount = reader.ReadUShort();
            int typesIndex;
            m_types = new System.Collections.Generic.List<uint>();
            for (typesIndex = 0; (typesIndex < typesCount); typesIndex = (typesIndex + 1))
            {
                m_types.Add(reader.ReadVarUhInt());
            }
            m_taxPercentage = reader.ReadFloat();
            m_taxModificationPercentage = reader.ReadFloat();
            m_maxItemLevel = reader.ReadSByte();
            m_maxItemPerAccount = reader.ReadVarUhInt();
            m_npcContextualId = reader.ReadInt();
            m_unsoldDelay = reader.ReadVarUhShort();
        }
    }
}
