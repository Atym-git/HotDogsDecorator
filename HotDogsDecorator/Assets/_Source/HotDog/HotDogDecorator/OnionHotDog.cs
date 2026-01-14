using UnityEngine;

public class OnionHotDog : AHotDogDecorator
{
    public OnionHotDog(AHotDog hotDog) : base(hotDog, hotDog.GetName(), hotDog.GetCost())
    {
    }

    public override int GetCost()
    {
        return base.GetCost() + 15;
    }
}
