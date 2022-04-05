namespace Exercicio15.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AddtionalCharge { get; set; }

        public OutsourcedEmployee() { }
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double addtionalCharge) : base(name, hours, valuePerHour)
        {
            AddtionalCharge = addtionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AddtionalCharge * 1.1;
        }
    }
}
