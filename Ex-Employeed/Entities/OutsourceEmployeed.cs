namespace Ex_Employeed.Entities
{
    class OutsourceEmployeed : Employeed
    {
        public double AdditionCharge { get; set; }

        public OutsourceEmployeed()
        {
        }

        public OutsourceEmployeed(string name, int hours, double valuePerHour, double additionCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionCharge = additionCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionCharge;
        }
    }
}
