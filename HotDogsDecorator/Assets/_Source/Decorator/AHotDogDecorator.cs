using UnityEngine;

public abstract class AHotDogDecorator : AHotDog
{
    protected AHotDog hotDog;
    public AHotDogDecorator(AHotDog hotDog, string name, int cost) : base(name, cost)
    {
        this.hotDog = hotDog;
    }
}
