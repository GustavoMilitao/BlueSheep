









// Generated on 12/11/2014 19:01:26
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GameContextCreateErrorMessage : Message
    {
        public new const uint ID =6024;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        
        public GameContextCreateErrorMessage()
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