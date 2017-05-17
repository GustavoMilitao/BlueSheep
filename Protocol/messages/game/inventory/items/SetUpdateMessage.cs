//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Inventory.Items
{
    using MageBot.Protocol.Types.Game.Data.Items.Effects;
    using System.Collections.Generic;
    using MageBot.Protocol.Types;


    public class SetUpdateMessage : Message
    {
        
        public override int ProtocolId { get; } = 5503;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_setObjects;
        
        public virtual List<System.UInt16> SetObjects
        {
            get
            {
                return m_setObjects;
            }
            set
            {
                m_setObjects = value;
            }
        }
        
        private List<ObjectEffect> m_setEffects;
        
        public virtual List<ObjectEffect> SetEffects
        {
            get
            {
                return m_setEffects;
            }
            set
            {
                m_setEffects = value;
            }
        }
        
        private ushort m_setId;
        
        public virtual ushort SetId
        {
            get
            {
                return m_setId;
            }
            set
            {
                m_setId = value;
            }
        }
        
        public SetUpdateMessage(List<System.UInt16> setObjects, List<ObjectEffect> setEffects, ushort setId)
        {
            m_setObjects = setObjects;
            m_setEffects = setEffects;
            m_setId = setId;
        }
        
        public SetUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_setId);
            writer.WriteShort(((short)(m_setObjects.Count)));
            int setObjectsIndex;
            for (setObjectsIndex = 0; (setObjectsIndex < m_setObjects.Count); setObjectsIndex = (setObjectsIndex + 1))
            {
                writer.WriteVarShort(m_setObjects[setObjectsIndex]);
            }
            writer.WriteShort(((short)(m_setEffects.Count)));
            int setEffectsIndex;
            for (setEffectsIndex = 0; (setEffectsIndex < m_setEffects.Count); setEffectsIndex = (setEffectsIndex + 1))
            {
                ObjectEffect objectToSend = m_setEffects[setEffectsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_setId = reader.ReadVarUhShort();
            int setObjectsCount = reader.ReadUShort();
            int setObjectsIndex;
            m_setObjects = new System.Collections.Generic.List<ushort>();
            for (setObjectsIndex = 0; (setObjectsIndex < setObjectsCount); setObjectsIndex = (setObjectsIndex + 1))
            {
                m_setObjects.Add(reader.ReadVarUhShort());
            }
            int setEffectsCount = reader.ReadUShort();
            int setEffectsIndex;
            m_setEffects = new System.Collections.Generic.List<ObjectEffect>();
            for (setEffectsIndex = 0; (setEffectsIndex < setEffectsCount); setEffectsIndex = (setEffectsIndex + 1))
            {
                ObjectEffect objectToAdd = ProtocolTypeManager.GetInstance<ObjectEffect>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_setEffects.Add(objectToAdd);
            }
        }
    }
}
