









// Generated on 12/11/2014 19:01:59
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ShortcutBarSwapErrorMessage : Message
    {
        public new const uint ID =6226;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public sbyte error;
        
        public ShortcutBarSwapErrorMessage()
        {
        }
        
        public ShortcutBarSwapErrorMessage(sbyte error)
        {
            this.error = error;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteSByte(error);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            error = reader.ReadSByte();
            if (error < 0)
                throw new Exception("Forbidden value on error = " + error + ", it doesn't respect the following condition : error < 0");
        }
        
    }
    
}