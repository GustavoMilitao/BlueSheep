


















// Generated on 12/11/2014 19:02:08
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

    public class TreasureHuntStepFight : TreasureHuntStep
{

public new const short ID = 462;
public override short TypeId
{
    get { return ID; }
}



public TreasureHuntStepFight()
{
}



public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            

}


}


}