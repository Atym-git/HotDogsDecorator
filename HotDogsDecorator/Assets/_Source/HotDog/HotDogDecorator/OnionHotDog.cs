using UnityEngine;

public class OnionHotDog : AHotDogDecorator
{
    public OnionHotDog(AHotDog hotDog) : base(hotDog)
    {
    }

    public override string GetName()
    {
        return base.GetName() + " с сладким луком";
    }

    public override int GetCost()
    {
        return base.GetCost() + 15;
    }
}
