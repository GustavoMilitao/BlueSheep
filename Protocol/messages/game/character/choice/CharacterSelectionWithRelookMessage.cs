//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Character.Choice
{


    public class CharacterSelectionWithRelookMessage : CharacterSelectionMessage
    {
        
        protected override int ProtocolId { get; set; } = 6353;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_cosmeticId;
        
        public virtual int CosmeticId
        {
            get
            {
                return m_cosmeticId;
            }
            set
            {
                m_cosmeticId = value;
            }
        }
        
        public CharacterSelectionWithRelookMessage(int cosmeticId)
        {
            m_cosmeticId = cosmeticId;
        }
        
        public CharacterSelectionWithRelookMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(m_cosmeticId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_cosmeticId = reader.ReadInt();
        }
    }
}
