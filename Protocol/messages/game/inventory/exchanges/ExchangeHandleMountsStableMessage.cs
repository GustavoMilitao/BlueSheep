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
    using System.Collections.Generic;


    public class ExchangeHandleMountsStableMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6562;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt32> m_ridesId;
        
        public virtual List<System.UInt32> RidesId
        {
            get
            {
                return m_ridesId;
            }
            set
            {
                m_ridesId = value;
            }
        }
        
        private byte m_actionType;
        
        public virtual byte ActionType
        {
            get
            {
                return m_actionType;
            }
            set
            {
                m_actionType = value;
            }
        }
        
        public ExchangeHandleMountsStableMessage(List<System.UInt32> ridesId, byte actionType)
        {
            m_ridesId = ridesId;
            m_actionType = actionType;
        }
        
        public ExchangeHandleMountsStableMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_ridesId.Count)));
            int ridesIdIndex;
            for (ridesIdIndex = 0; (ridesIdIndex < m_ridesId.Count); ridesIdIndex = (ridesIdIndex + 1))
            {
                writer.WriteVarInt(m_ridesId[ridesIdIndex]);
            }
            writer.WriteByte(m_actionType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int ridesIdCount = reader.ReadUShort();
            int ridesIdIndex;
            m_ridesId = new System.Collections.Generic.List<uint>();
            for (ridesIdIndex = 0; (ridesIdIndex < ridesIdCount); ridesIdIndex = (ridesIdIndex + 1))
            {
                m_ridesId.Add(reader.ReadVarUhInt());
            }
            m_actionType = reader.ReadByte();
        }
    }
}
