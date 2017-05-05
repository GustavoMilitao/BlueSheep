









// Generated on 12/11/2014 19:01:24
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class PlayerStatusUpdateRequestMessage : Message
    {
        public new const uint ID =6387;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public Types.PlayerStatus status;
        
        public PlayerStatusUpdateRequestMessage()
        {
        }
        
        public PlayerStatusUpdateRequestMessage(Types.PlayerStatus status)
        {
            this.status = status;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            status = Types.ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadShort());
            status.Deserialize(reader);
        }
        
    }
    
}