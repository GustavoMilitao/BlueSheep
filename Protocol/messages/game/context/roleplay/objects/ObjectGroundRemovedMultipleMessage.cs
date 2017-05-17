//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Objects
{
    using System.Collections.Generic;


    public class ObjectGroundRemovedMultipleMessage : Message
    {
        
        public override int ProtocolId { get; } = 5944;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_cells;
        
        public virtual List<System.UInt16> Cells
        {
            get
            {
                return m_cells;
            }
            set
            {
                m_cells = value;
            }
        }
        
        public ObjectGroundRemovedMultipleMessage(List<System.UInt16> cells)
        {
            m_cells = cells;
        }
        
        public ObjectGroundRemovedMultipleMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_cells.Count)));
            int cellsIndex;
            for (cellsIndex = 0; (cellsIndex < m_cells.Count); cellsIndex = (cellsIndex + 1))
            {
                writer.WriteVarShort(m_cells[cellsIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int cellsCount = reader.ReadUShort();
            int cellsIndex;
            m_cells = new System.Collections.Generic.List<ushort>();
            for (cellsIndex = 0; (cellsIndex < cellsCount); cellsIndex = (cellsIndex + 1))
            {
                m_cells.Add(reader.ReadVarUhShort());
            }
        }
    }
}
