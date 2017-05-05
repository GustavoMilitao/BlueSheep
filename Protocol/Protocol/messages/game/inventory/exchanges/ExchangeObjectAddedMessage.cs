









// Generated on 12/11/2014 19:01:50
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ExchangeObjectAddedMessage : ExchangeObjectMessage
    {
        public new const uint ID =5516;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public Types.ObjectItem @object;
        
        public ExchangeObjectAddedMessage()
        {
        }
        
        public ExchangeObjectAddedMessage(bool remote, Types.ObjectItem @object)
         : base(remote)
        {
            this.@object = @object;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            base.Serialize(writer);
            @object.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            base.Deserialize(reader);
            @object = new Types.ObjectItem();
            @object.Deserialize(reader);
        }
        
    }
    
}