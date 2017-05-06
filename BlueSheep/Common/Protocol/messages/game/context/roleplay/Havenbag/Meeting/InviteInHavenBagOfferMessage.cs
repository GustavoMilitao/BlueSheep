//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Havenbag.Meeting
{
    using BlueSheep.Common.Protocol.Types.Game.Character;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class InviteInHavenBagOfferMessage : Message
    {
        
        public const int ProtocolId = 6643;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private CharacterMinimalInformations m_hostInformations;
        
        public virtual CharacterMinimalInformations HostInformations
        {
            get
            {
                return m_hostInformations;
            }
            set
            {
                m_hostInformations = value;
            }
        }
        
        private int m_timeLeftBeforeCancel;
        
        public virtual int TimeLeftBeforeCancel
        {
            get
            {
                return m_timeLeftBeforeCancel;
            }
            set
            {
                m_timeLeftBeforeCancel = value;
            }
        }
        
        public InviteInHavenBagOfferMessage(CharacterMinimalInformations hostInformations, int timeLeftBeforeCancel)
        {
            m_hostInformations = hostInformations;
            m_timeLeftBeforeCancel = timeLeftBeforeCancel;
        }
        
        public InviteInHavenBagOfferMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_hostInformations.Serialize(writer);
            writer.WriteVarInt(m_timeLeftBeforeCancel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_hostInformations = new CharacterMinimalInformations();
            m_hostInformations.Deserialize(reader);
            m_timeLeftBeforeCancel = reader.ReadVarInt();
        }
    }
}