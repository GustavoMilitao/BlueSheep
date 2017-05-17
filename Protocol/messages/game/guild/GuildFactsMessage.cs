//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Guild
{
    using MageBot.Protocol.Types.Game.Social;
    using MageBot.Protocol.Types.Game.Character;
    using System.Collections.Generic;
    using MageBot.Protocol.Types;


    public class GuildFactsMessage : Message
    {
        
        public override int ProtocolId { get; } = 6415;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildFactSheetInformations m_infos;
        
        public virtual GuildFactSheetInformations Infos
        {
            get
            {
                return m_infos;
            }
            set
            {
                m_infos = value;
            }
        }
        
        private List<CharacterMinimalInformations> m_members;
        
        public virtual List<CharacterMinimalInformations> Members
        {
            get
            {
                return m_members;
            }
            set
            {
                m_members = value;
            }
        }
        
        private int m_creationDate;
        
        public virtual int CreationDate
        {
            get
            {
                return m_creationDate;
            }
            set
            {
                m_creationDate = value;
            }
        }
        
        private ushort m_nbTaxCollectors;
        
        public virtual ushort NbTaxCollectors
        {
            get
            {
                return m_nbTaxCollectors;
            }
            set
            {
                m_nbTaxCollectors = value;
            }
        }
        
        public GuildFactsMessage(GuildFactSheetInformations infos, List<CharacterMinimalInformations> members, int creationDate, ushort nbTaxCollectors)
        {
            m_infos = infos;
            m_members = members;
            m_creationDate = creationDate;
            m_nbTaxCollectors = nbTaxCollectors;
        }
        
        public GuildFactsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(((ushort)(m_infos.TypeID)));
            m_infos.Serialize(writer);
            writer.WriteShort(((short)(m_members.Count)));
            int membersIndex;
            for (membersIndex = 0; (membersIndex < m_members.Count); membersIndex = (membersIndex + 1))
            {
                CharacterMinimalInformations objectToSend = m_members[membersIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteInt(m_creationDate);
            writer.WriteVarShort(m_nbTaxCollectors);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_infos = ProtocolTypeManager.GetInstance<GuildFactSheetInformations>(reader.ReadUShort());
            m_infos.Deserialize(reader);
            int membersCount = reader.ReadUShort();
            int membersIndex;
            m_members = new System.Collections.Generic.List<CharacterMinimalInformations>();
            for (membersIndex = 0; (membersIndex < membersCount); membersIndex = (membersIndex + 1))
            {
                CharacterMinimalInformations objectToAdd = new CharacterMinimalInformations();
                objectToAdd.Deserialize(reader);
                m_members.Add(objectToAdd);
            }
            m_creationDate = reader.ReadInt();
            m_nbTaxCollectors = reader.ReadVarUhShort();
        }
    }
}
