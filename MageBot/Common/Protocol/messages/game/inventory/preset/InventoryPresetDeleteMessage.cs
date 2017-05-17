//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Inventory.Preset
{
    using BlueSheep.Common;


    public class InventoryPresetDeleteMessage : Message
    {
        
        public const int ProtocolId = 6169;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_presetId;
        
        public virtual byte PresetId
        {
            get
            {
                return m_presetId;
            }
            set
            {
                m_presetId = value;
            }
        }
        
        public InventoryPresetDeleteMessage(byte presetId)
        {
            m_presetId = presetId;
        }
        
        public InventoryPresetDeleteMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_presetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_presetId = reader.ReadByte();
        }
    }
}