//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Inventory.Exchanges
{


    public class ExchangeStartOkCraftWithInformationMessage : ExchangeStartOkCraftMessage
    {
        
        public const int ProtocolId = 5941;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_skillId;
        
        public virtual uint SkillId
        {
            get
            {
                return m_skillId;
            }
            set
            {
                m_skillId = value;
            }
        }
        
        public ExchangeStartOkCraftWithInformationMessage(uint skillId)
        {
            m_skillId = skillId;
        }
        
        public ExchangeStartOkCraftWithInformationMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt(m_skillId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_skillId = reader.ReadVarUhInt();
        }
    }
}