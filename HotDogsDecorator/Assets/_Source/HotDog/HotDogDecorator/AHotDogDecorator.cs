using UnityEngine;

public abstract class AHotDogDecorator : AHotDog
{
    protected AHotDog hotDog;
    public AHotDogDecorator(AHotDog hotDog) : base(hotDog.GetName(), hotDog.GetCost(), hotDog.Weight)
    {
        this.hotDog = hotDog;
    }
}
