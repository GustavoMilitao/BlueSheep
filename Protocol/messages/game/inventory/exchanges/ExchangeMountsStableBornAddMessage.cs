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


    public class ExchangeMountsStableBornAddMessage : ExchangeMountsStableAddMessage
    {
        
        protected override int ProtocolId { get; set; } = 6557;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        public ExchangeMountsStableBornAddMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
    }
}
