//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Roleplay
{


    public class GameRolePlayMountInformations : GameRolePlayNamedActorInformations
    {
        
        public override int ProtocolId { get; } = 180;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_ownerName;
        
        public virtual string OwnerName
        {
            get
            {
                return m_ownerName;
            }
            set
            {
                m_ownerName = value;
            }
        }
        
        private sbyte m_level;
        
        public virtual sbyte Level
        {
            get
            {
                return m_level;
            }
            set
            {
                m_level = value;
            }
        }
        
        public GameRolePlayMountInformations(string ownerName, sbyte level)
        {
            m_ownerName = ownerName;
            m_level = level;
        }
        
        public GameRolePlayMountInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_ownerName);
            writer.WriteSByte(m_level);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_ownerName = reader.ReadUTF();
            m_level = reader.ReadSByte();
        }
    }
}
