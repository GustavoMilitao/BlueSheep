









// Generated on 12/11/2014 19:01:52
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ExchangeStartOkCraftMessage : Message
    {
        public new const uint ID =5813;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        
        public ExchangeStartOkCraftMessage()
        {
        }
        
        
        public override void Serialize(BigEndianWriter writer)
        {
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
        }
        
    }
    
}