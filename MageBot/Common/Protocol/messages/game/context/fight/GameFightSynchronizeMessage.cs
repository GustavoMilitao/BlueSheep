//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Fight
{
    using BlueSheep.Common.Protocol.Types.Game.Context.Fight;
    using System.Collections.Generic;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class GameFightSynchronizeMessage : Message
    {
        
        public const int ProtocolId = 5921;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<GameFightFighterInformations> m_fighters;
        
        public virtual List<GameFightFighterInformations> Fighters
        {
            get
            {
                return m_fighters;
            }
            set
            {
                m_fighters = value;
            }
        }
        
        public GameFightSynchronizeMessage(List<GameFightFighterInformations> fighters)
        {
            m_fighters = fighters;
        }
        
        public GameFightSynchronizeMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_fighters.Count)));
            int fightersIndex;
            for (fightersIndex = 0; (fightersIndex < m_fighters.Count); fightersIndex = (fightersIndex + 1))
            {
                GameFightFighterInformations objectToSend = m_fighters[fightersIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int fightersCount = reader.ReadUShort();
            int fightersIndex;
            m_fighters = new System.Collections.Generic.List<GameFightFighterInformations>();
            for (fightersIndex = 0; (fightersIndex < fightersCount); fightersIndex = (fightersIndex + 1))
            {
                GameFightFighterInformations objectToAdd = ProtocolTypeManager.GetInstance<GameFightFighterInformations>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_fighters.Add(objectToAdd);
            }
        }
    }
}
