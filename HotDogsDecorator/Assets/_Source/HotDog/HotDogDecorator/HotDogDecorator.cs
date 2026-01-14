namespace _Source.HotDog.HotDogDecorator
{
    public class HotDogDecorator : AHotDogDecorator
    {
        public HotDogDecorator(AHotDog hotDog, string name, int cost, float weight) : base(hotDog)
        {
            _cost = cost;
            _name = name;
            Weight += weight;
        }

        public override int GetCost()
        {
            return hotDog.GetCost() +  _cost;
        }

        public override string GetName()
        {
            return hotDog.GetName() + " " + _name;
        }
    }
}