namespace Exercicio18.Entities
{
    class IndividualAccount : Account
    {
        public double HealthExpenses { get; set; }

        public IndividualAccount() { }
        public IndividualAccount(string name, double anualAmount, double healthExpenses) : base(name, anualAmount)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Tax()
        {
            if (AnualAmount < 20000.00)
            {
                    return AnualAmount * 0.15 - HealthExpenses * 0.50;
            }
            else
            {
                return AnualAmount * 0.25 - HealthExpenses * 0.50;
            }
        }
    }
}
