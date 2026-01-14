namespace _Source.HotDog.HotDogDecorator
{
    public class HotDogDecorator : OnionHotDog
    {
        private int _cost;
        private string _name;
        
        public HotDogDecorator(AHotDog hotDog, string name, int cost, float weight) : base(hotDog)
        {
            _cost = cost;
            _name = name;
            Weight += weight;
        }

        override public int GetCost()
        {
            return hotDog.GetCost() +  _cost;
        }

        public override string GetName()
        {
            return base.GetName() + " " + _name;
        }
    }
}