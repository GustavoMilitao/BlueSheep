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
    public class GuildFightLeaveRequestMessage : Message
    {
        
        public override int ProtocolId { get; } = 5715;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_taxCollectorId;
        
        public virtual int TaxCollectorId
        {
            get
            {
                return m_taxCollectorId;
            }
            set
            {
                m_taxCollectorId = value;
            }
        }
        
        private ulong m_characterId;
        
        public virtual ulong CharacterId
        {
            get
            {
                return m_characterId;
            }
            set
            {
                m_characterId = value;
            }
        }
        
        public GuildFightLeaveRequestMessage(int taxCollectorId, ulong characterId)
        {
            m_taxCollectorId = taxCollectorId;
            m_characterId = characterId;
        }
        
        public GuildFightLeaveRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_taxCollectorId);
            writer.WriteVarLong(m_characterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_taxCollectorId = reader.ReadInt();
            m_characterId = reader.ReadVarUhLong();
        }
    }
}
