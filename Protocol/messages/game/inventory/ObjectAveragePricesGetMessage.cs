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
    public class ObjectAveragePricesGetMessage : Message
    {
        
        public override int ProtocolId { get; } = 6334;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        public ObjectAveragePricesGetMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
    }
}
