using UnityEngine;

public class PicklesHotDog : AHotDogDecorator
{
    public PicklesHotDog(AHotDog hotDog) : base(hotDog, hotDog.GetName(), hotDog.GetCost())
    {
    }

    public override string GetName()
    {
        return base.GetName() + " с маринованными огурцами";
    }

    public override int GetCost()
    {
        return base.GetCost() + 25;
    }
}
