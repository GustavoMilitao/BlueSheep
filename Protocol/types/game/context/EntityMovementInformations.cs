//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context
{
    using System.Collections.Generic;
    using MageBot.Protocol.Types;


    public class EntityMovementInformations : NetworkType
    {
        
        protected override int ProtocolId { get; set; } = 63;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Byte> m_steps;
        
        public virtual List<System.Byte> Steps
        {
            get
            {
                return m_steps;
            }
            set
            {
                m_steps = value;
            }
        }
        
        private int m_ObjectId;
        
        public virtual int ObjectId
        {
            get
            {
                return m_ObjectId;
            }
            set
            {
                m_ObjectId = value;
            }
        }
        
        public EntityMovementInformations(List<System.Byte> steps, int objectId)
        {
            m_steps = steps;
            m_ObjectId = objectId;
        }
        
        public EntityMovementInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_steps.Count)));
            int stepsIndex;
            for (stepsIndex = 0; (stepsIndex < m_steps.Count); stepsIndex = (stepsIndex + 1))
            {
                writer.WriteByte(m_steps[stepsIndex]);
            }
            writer.WriteInt(m_ObjectId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int stepsCount = reader.ReadUShort();
            int stepsIndex;
            m_steps = new System.Collections.Generic.List<byte>();
            for (stepsIndex = 0; (stepsIndex < stepsCount); stepsIndex = (stepsIndex + 1))
            {
                m_steps.Add(reader.ReadByte());
            }
            m_ObjectId = reader.ReadInt();
        }
    }
}
