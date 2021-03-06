//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Paddock
{
    using System.Collections.Generic;
    using BlueSheep.Common;


    public class GameDataPlayFarmObjectAnimationMessage : Message
    {
        
        public const int ProtocolId = 6026;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_cellId;
        
        public virtual List<System.UInt16> CellId
        {
            get
            {
                return m_cellId;
            }
            set
            {
                m_cellId = value;
            }
        }
        
        public GameDataPlayFarmObjectAnimationMessage(List<System.UInt16> cellId)
        {
            m_cellId = cellId;
        }
        
        public GameDataPlayFarmObjectAnimationMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_cellId.Count)));
            int cellIdIndex;
            for (cellIdIndex = 0; (cellIdIndex < m_cellId.Count); cellIdIndex = (cellIdIndex + 1))
            {
                writer.WriteVarShort(m_cellId[cellIdIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int cellIdCount = reader.ReadUShort();
            int cellIdIndex;
            m_cellId = new System.Collections.Generic.List<ushort>();
            for (cellIdIndex = 0; (cellIdIndex < cellIdCount); cellIdIndex = (cellIdIndex + 1))
            {
                m_cellId.Add(reader.ReadVarUhShort());
            }
        }
    }
}
