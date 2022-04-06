namespace Exercicio18.Entities
{
    abstract class Account
    {
        public string Name { get; set; }
        public double AnualAmount { get; set; }

        public Account() { }

        protected Account(string name, double anualAmount)
        {
            Name = name;
            AnualAmount = anualAmount;
        }

        public abstract double Tax();
    }
}
