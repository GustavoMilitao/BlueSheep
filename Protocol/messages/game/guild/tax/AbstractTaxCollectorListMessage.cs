//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Guild.Tax
{
    using MageBot.Protocol.Types.Game.Guild.Tax;
    using System.Collections.Generic;
    using MageBot.Protocol.Types;


    public class AbstractTaxCollectorListMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6568;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<TaxCollectorInformations> m_informations;
        
        public virtual List<TaxCollectorInformations> Informations
        {
            get
            {
                return m_informations;
            }
            set
            {
                m_informations = value;
            }
        }
        
        public AbstractTaxCollectorListMessage(List<TaxCollectorInformations> informations)
        {
            m_informations = informations;
        }
        
        public AbstractTaxCollectorListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_informations.Count)));
            int informationsIndex;
            for (informationsIndex = 0; (informationsIndex < m_informations.Count); informationsIndex = (informationsIndex + 1))
            {
                TaxCollectorInformations objectToSend = m_informations[informationsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int informationsCount = reader.ReadUShort();
            int informationsIndex;
            m_informations = new System.Collections.Generic.List<TaxCollectorInformations>();
            for (informationsIndex = 0; (informationsIndex < informationsCount); informationsIndex = (informationsIndex + 1))
            {
                TaxCollectorInformations objectToAdd = ProtocolTypeManager.GetInstance<TaxCollectorInformations>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_informations.Add(objectToAdd);
            }
        }
    }
}
