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


    public class ObtainedItemWithBonusMessage : ObtainedItemMessage
    {
        
        protected override int ProtocolId { get; set; } = 6520;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_bonusQuantity;
        
        public virtual uint BonusQuantity
        {
            get
            {
                return m_bonusQuantity;
            }
            set
            {
                m_bonusQuantity = value;
            }
        }
        
        public ObtainedItemWithBonusMessage(uint bonusQuantity)
        {
            m_bonusQuantity = bonusQuantity;
        }
        
        public ObtainedItemWithBonusMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt(m_bonusQuantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_bonusQuantity = reader.ReadVarUhInt();
        }
    }
}
