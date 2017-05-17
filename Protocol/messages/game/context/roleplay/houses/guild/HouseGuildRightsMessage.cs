//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Houses.Guild
{
    using MageBot.Protocol.Types.Game.Context.Roleplay;


    public class HouseGuildRightsMessage : Message
    {
        
        public override int ProtocolId { get; } = 5703;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildInformations m_guildInfo;
        
        public virtual GuildInformations GuildInfo
        {
            get
            {
                return m_guildInfo;
            }
            set
            {
                m_guildInfo = value;
            }
        }
        
        private uint m_houseId;
        
        public virtual uint HouseId
        {
            get
            {
                return m_houseId;
            }
            set
            {
                m_houseId = value;
            }
        }
        
        private int m_instanceId;
        
        public virtual int InstanceId
        {
            get
            {
                return m_instanceId;
            }
            set
            {
                m_instanceId = value;
            }
        }
        
        private bool m_secondHand;
        
        public virtual bool SecondHand
        {
            get
            {
                return m_secondHand;
            }
            set
            {
                m_secondHand = value;
            }
        }
        
        private uint m_rights;
        
        public virtual uint Rights
        {
            get
            {
                return m_rights;
            }
            set
            {
                m_rights = value;
            }
        }
        
        public HouseGuildRightsMessage(GuildInformations guildInfo, uint houseId, int instanceId, bool secondHand, uint rights)
        {
            m_guildInfo = guildInfo;
            m_houseId = houseId;
            m_instanceId = instanceId;
            m_secondHand = secondHand;
            m_rights = rights;
        }
        
        public HouseGuildRightsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_guildInfo.Serialize(writer);
            writer.WriteVarInt(m_houseId);
            writer.WriteInt(m_instanceId);
            writer.WriteBoolean(m_secondHand);
            writer.WriteVarInt(m_rights);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_guildInfo = new GuildInformations();
            m_guildInfo.Deserialize(reader);
            m_houseId = reader.ReadVarUhInt();
            m_instanceId = reader.ReadInt();
            m_secondHand = reader.ReadBoolean();
            m_rights = reader.ReadVarUhInt();
        }
    }
}
