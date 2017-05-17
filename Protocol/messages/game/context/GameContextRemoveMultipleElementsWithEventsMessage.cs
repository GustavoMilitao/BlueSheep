//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context
{
    using System.Collections.Generic;


    public class GameContextRemoveMultipleElementsWithEventsMessage : GameContextRemoveMultipleElementsMessage
    {
        
        protected override int ProtocolId { get; set; } = 6416;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Byte> m_elementEventIds;
        
        public virtual List<System.Byte> ElementEventIds
        {
            get
            {
                return m_elementEventIds;
            }
            set
            {
                m_elementEventIds = value;
            }
        }
        
        public GameContextRemoveMultipleElementsWithEventsMessage(List<System.Byte> elementEventIds)
        {
            m_elementEventIds = elementEventIds;
        }
        
        public GameContextRemoveMultipleElementsWithEventsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_elementEventIds.Count)));
            int elementEventIdsIndex;
            for (elementEventIdsIndex = 0; (elementEventIdsIndex < m_elementEventIds.Count); elementEventIdsIndex = (elementEventIdsIndex + 1))
            {
                writer.WriteByte(m_elementEventIds[elementEventIdsIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int elementEventIdsCount = reader.ReadUShort();
            int elementEventIdsIndex;
            m_elementEventIds = new System.Collections.Generic.List<byte>();
            for (elementEventIdsIndex = 0; (elementEventIdsIndex < elementEventIdsCount); elementEventIdsIndex = (elementEventIdsIndex + 1))
            {
                m_elementEventIds.Add(reader.ReadByte());
            }
        }
    }
}
