









// Generated on 12/11/2014 19:01:22
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class CharacterFirstSelectionMessage : CharacterSelectionMessage
    {
        public new const uint ID =6084;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public bool doTutorial;
        
        public CharacterFirstSelectionMessage()
        {
        }
        
        public CharacterFirstSelectionMessage(ulong id, bool doTutorial)
         : base(id)
        {
            this.doTutorial = doTutorial;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(doTutorial);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            base.Deserialize(reader);
            doTutorial = reader.ReadBoolean();
        }
        
    }
    
}