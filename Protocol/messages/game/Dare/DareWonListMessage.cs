//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Dare
{
    using System.Collections.Generic;


    public class DareWonListMessage : Message
    {
        
        public override int ProtocolId { get; } = 6682;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Double> m_dareId;
        
        public virtual List<System.Double> DareId
        {
            get
            {
                return m_dareId;
            }
            set
            {
                m_dareId = value;
            }
        }
        
        public DareWonListMessage(List<System.Double> dareId)
        {
            m_dareId = dareId;
        }
        
        public DareWonListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_dareId.Count)));
            int dareIdIndex;
            for (dareIdIndex = 0; (dareIdIndex < m_dareId.Count); dareIdIndex = (dareIdIndex + 1))
            {
                writer.WriteDouble(m_dareId[dareIdIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int dareIdCount = reader.ReadUShort();
            int dareIdIndex;
            m_dareId = new System.Collections.Generic.List<double>();
            for (dareIdIndex = 0; (dareIdIndex < dareIdCount); dareIdIndex = (dareIdIndex + 1))
            {
                m_dareId.Add(reader.ReadDouble());
            }
        }
    }
}
