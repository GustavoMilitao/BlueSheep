









// Generated on 12/11/2014 19:01:47
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class TeleportToBuddyAnswerMessage : Message
    {
        public new const uint ID =6293;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public short dungeonId;
        public int buddyId;
        public bool accept;
        
        public TeleportToBuddyAnswerMessage()
        {
        }
        
        public TeleportToBuddyAnswerMessage(short dungeonId, int buddyId, bool accept)
        {
            this.dungeonId = dungeonId;
            this.buddyId = buddyId;
            this.accept = accept;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarShort(dungeonId);
            writer.WriteVarInt(buddyId);
            writer.WriteBoolean(accept);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            dungeonId = reader.ReadVarShort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            buddyId = reader.ReadVarInt();
            if (buddyId < 0)
                throw new Exception("Forbidden value on buddyId = " + buddyId + ", it doesn't respect the following condition : buddyId < 0");
            accept = reader.ReadBoolean();
        }
        
    }
    
}