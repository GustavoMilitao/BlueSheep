//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Inventory.Preset
{
    using MageBot.Protocol.Types.Game.Inventory.Preset;


    public class InventoryPresetUpdateMessage : Message
    {
        
        public override int ProtocolId { get; } = 6171;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private Preset m_preset;
        
        public virtual Preset Preset
        {
            get
            {
                return m_preset;
            }
            set
            {
                m_preset = value;
            }
        }
        
        public InventoryPresetUpdateMessage(Preset preset)
        {
            m_preset = preset;
        }
        
        public InventoryPresetUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_preset.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_preset = new Preset();
            m_preset.Deserialize(reader);
        }
    }
}
