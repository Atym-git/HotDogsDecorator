using UnityEngine;

public abstract class AHotDog
{
    protected string _name;
    protected int _cost;

    public AHotDog(string name, int cost, float weight)
    {
        _name = name;
        _cost = cost;
        Weight = weight;
    }

    public float Weight { get; protected set; }
    
    public virtual string GetName()
    {
        return _name;
    }
    public virtual int GetCost()
    {
        return _cost;
    }
}
