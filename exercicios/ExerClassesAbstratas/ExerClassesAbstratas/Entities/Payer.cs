
namespace ExerClassesAbstratas.Entities
{
    abstract class Payer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected Payer()
        {
        }

        protected Payer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes();

        public abstract override string ToString();


    }
}
