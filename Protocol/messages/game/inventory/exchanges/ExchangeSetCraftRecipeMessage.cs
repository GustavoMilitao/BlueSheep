//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Inventory.Exchanges
{
    public class ExchangeSetCraftRecipeMessage : Message
    {
        
        public override int ProtocolId { get; } = 6389;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_objectGID;
        
        public virtual ushort ObjectGID
        {
            get
            {
                return m_objectGID;
            }
            set
            {
                m_objectGID = value;
            }
        }
        
        public ExchangeSetCraftRecipeMessage(ushort objectGID)
        {
            m_objectGID = objectGID;
        }
        
        public ExchangeSetCraftRecipeMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_objectGID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_objectGID = reader.ReadVarUhShort();
        }
    }
}
