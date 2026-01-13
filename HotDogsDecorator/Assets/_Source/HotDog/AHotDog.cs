using UnityEngine;

public abstract class AHotDog
{
    private string _name;
    private int _cost;

    public AHotDog(string name, int cost)
    {
        _name = name;
        _cost = cost;
    }

    public virtual string GetName()
    {
        return _name;
    }
    public virtual int GetCost()
    {
        return _cost;
    }
    
}
