//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Roleplay.TreasureHunt
{


    public class TreasureHuntStepDig : TreasureHuntStep
    {
        
        protected override int ProtocolId { get; set; } = 465;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        public TreasureHuntStepDig()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
    }
}
