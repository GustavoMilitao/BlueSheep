//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Party
{
    using System.Collections.Generic;


    public class PartyInvitationDungeonDetailsMessage : PartyInvitationDetailsMessage
    {
        
        protected override int ProtocolId { get; set; } = 6262;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Boolean> m_playersDungeonReady;
        
        public virtual List<System.Boolean> PlayersDungeonReady
        {
            get
            {
                return m_playersDungeonReady;
            }
            set
            {
                m_playersDungeonReady = value;
            }
        }
        
        private ushort m_dungeonId;
        
        public virtual ushort DungeonId
        {
            get
            {
                return m_dungeonId;
            }
            set
            {
                m_dungeonId = value;
            }
        }
        
        public PartyInvitationDungeonDetailsMessage(List<System.Boolean> playersDungeonReady, ushort dungeonId)
        {
            m_playersDungeonReady = playersDungeonReady;
            m_dungeonId = dungeonId;
        }
        
        public PartyInvitationDungeonDetailsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_playersDungeonReady.Count)));
            int playersDungeonReadyIndex;
            for (playersDungeonReadyIndex = 0; (playersDungeonReadyIndex < m_playersDungeonReady.Count); playersDungeonReadyIndex = (playersDungeonReadyIndex + 1))
            {
                writer.WriteBoolean(m_playersDungeonReady[playersDungeonReadyIndex]);
            }
            writer.WriteVarShort(m_dungeonId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int playersDungeonReadyCount = reader.ReadUShort();
            int playersDungeonReadyIndex;
            m_playersDungeonReady = new System.Collections.Generic.List<bool>();
            for (playersDungeonReadyIndex = 0; (playersDungeonReadyIndex < playersDungeonReadyCount); playersDungeonReadyIndex = (playersDungeonReadyIndex + 1))
            {
                m_playersDungeonReady.Add(reader.ReadBoolean());
            }
            m_dungeonId = reader.ReadVarUhShort();
        }
    }
}
