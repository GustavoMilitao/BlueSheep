//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Inventory.Items
{


    public class ObjectUseMultipleMessage : ObjectUseMessage
    {
        
        public override int ProtocolId { get; } = 6234;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_quantity;
        
        public virtual uint Quantity
        {
            get
            {
                return m_quantity;
            }
            set
            {
                m_quantity = value;
            }
        }
        
        public ObjectUseMultipleMessage(uint quantity)
        {
            m_quantity = quantity;
        }
        
        public ObjectUseMultipleMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt(m_quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_quantity = reader.ReadVarUhInt();
        }
    }
}
