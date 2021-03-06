//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Fight
{
    using MageBot.Protocol.Types.Game.Idol;
    using System.Collections.Generic;


    public class GameFightStartMessage : Message
    {
        
        public override int ProtocolId { get; } = 712;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<Idol> m_idols;
        
        public virtual List<Idol> Idols
        {
            get
            {
                return m_idols;
            }
            set
            {
                m_idols = value;
            }
        }
        
        public GameFightStartMessage(List<Idol> idols)
        {
            m_idols = idols;
        }
        
        public GameFightStartMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_idols.Count)));
            int idolsIndex;
            for (idolsIndex = 0; (idolsIndex < m_idols.Count); idolsIndex = (idolsIndex + 1))
            {
                Idol objectToSend = m_idols[idolsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int idolsCount = reader.ReadUShort();
            int idolsIndex;
            m_idols = new System.Collections.Generic.List<Idol>();
            for (idolsIndex = 0; (idolsIndex < idolsCount); idolsIndex = (idolsIndex + 1))
            {
                Idol objectToAdd = new Idol();
                objectToAdd.Deserialize(reader);
                m_idols.Add(objectToAdd);
            }
        }
    }
}
