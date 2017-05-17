//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Prism
{
    using MageBot.Protocol.Types;
    using MageBot.Protocol.Types.Game.Prism;
    using System.Collections.Generic;


    public class PrismsListMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6440;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<PrismSubareaEmptyInfo> m_prisms;
        
        public virtual List<PrismSubareaEmptyInfo> Prisms
        {
            get
            {
                return m_prisms;
            }
            set
            {
                m_prisms = value;
            }
        }
        
        public PrismsListMessage(List<PrismSubareaEmptyInfo> prisms)
        {
            m_prisms = prisms;
        }
        
        public PrismsListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_prisms.Count)));
            int prismsIndex;
            for (prismsIndex = 0; (prismsIndex < m_prisms.Count); prismsIndex = (prismsIndex + 1))
            {
                PrismSubareaEmptyInfo objectToSend = m_prisms[prismsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int prismsCount = reader.ReadUShort();
            int prismsIndex;
            m_prisms = new System.Collections.Generic.List<PrismSubareaEmptyInfo>();
            for (prismsIndex = 0; (prismsIndex < prismsCount); prismsIndex = (prismsIndex + 1))
            {
                PrismSubareaEmptyInfo objectToAdd = ProtocolTypeManager.GetInstance<PrismSubareaEmptyInfo>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_prisms.Add(objectToAdd);
            }
        }
    }
}
