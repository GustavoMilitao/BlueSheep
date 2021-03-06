//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Data.Items
{


    public class ObjectItemGenericQuantityPrice : ObjectItemGenericQuantity
    {
        
        public const int ProtocolId = 494;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_price;
        
        public virtual ulong Price
        {
            get
            {
                return m_price;
            }
            set
            {
                m_price = value;
            }
        }
        
        public ObjectItemGenericQuantityPrice(ulong price)
        {
            m_price = price;
        }
        
        public ObjectItemGenericQuantityPrice()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(m_price);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_price = reader.ReadVarUhLong();
        }
    }
}
