//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Data.Items
{
    using MageBot.Protocol.Types.Game.Data.Items.Effects;
    using System.Collections.Generic;


    public class ObjectItemToSell : Item
    {
        
        protected override int ProtocolId { get; set; } = 120;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ObjectEffect> m_effects;
        
        public virtual List<ObjectEffect> Effects
        {
            get
            {
                return m_effects;
            }
            set
            {
                m_effects = value;
            }
        }
        
        private ushort m_objectGID;
        
        public virtual ushort ObjectGID
        {
            get
            {
                return m_objectGID;
            }
            set
            {
                m_objectGID = value;
            }
        }
        
        private uint m_objectUID;
        
        public virtual uint ObjectUID
        {
            get
            {
                return m_objectUID;
            }
            set
            {
                m_objectUID = value;
            }
        }
        
        private uint m_quantity;
        
        public virtual uint Quantity
        {
            get
            {
                return m_quantity;
            }
            set
            {
                m_quantity = value;
            }
        }
        
        private ulong m_objectPrice;
        
        public virtual ulong ObjectPrice
        {
            get
            {
                return m_objectPrice;
            }
            set
            {
                m_objectPrice = value;
            }
        }
        
        public ObjectItemToSell(List<ObjectEffect> effects, ushort objectGID, uint objectUID, uint quantity, ulong objectPrice)
        {
            m_effects = effects;
            m_objectGID = objectGID;
            m_objectUID = objectUID;
            m_quantity = quantity;
            m_objectPrice = objectPrice;
        }
        
        public ObjectItemToSell()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_effects.Count)));
            int effectsIndex;
            for (effectsIndex = 0; (effectsIndex < m_effects.Count); effectsIndex = (effectsIndex + 1))
            {
                ObjectEffect objectToSend = m_effects[effectsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteVarShort(m_objectGID);
            writer.WriteVarInt(m_objectUID);
            writer.WriteVarInt(m_quantity);
            writer.WriteVarLong(m_objectPrice);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int effectsCount = reader.ReadUShort();
            int effectsIndex;
            m_effects = new System.Collections.Generic.List<ObjectEffect>();
            for (effectsIndex = 0; (effectsIndex < effectsCount); effectsIndex = (effectsIndex + 1))
            {
                ObjectEffect objectToAdd = ProtocolTypeManager.GetInstance<ObjectEffect>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_effects.Add(objectToAdd);
            }
            m_objectGID = reader.ReadVarUhShort();
            m_objectUID = reader.ReadVarUhInt();
            m_quantity = reader.ReadVarUhInt();
            m_objectPrice = reader.ReadVarUhLong();
        }
    }
}
