









// Generated on 12/11/2014 19:01:19
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GameActionFightThrowCharacterMessage : AbstractGameActionMessage
    {
        public new const uint ID =5829;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int targetId;
        public short cellId;
        
        public GameActionFightThrowCharacterMessage()
        {
        }
        
        public GameActionFightThrowCharacterMessage(short actionId, int sourceId, int targetId, short cellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteShort(cellId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadInt();
            cellId = reader.ReadShort();
            if (cellId < -1 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < -1 || cellId > 559");
        }
        
    }
    
}