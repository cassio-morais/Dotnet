using System.Globalization;

namespace ExerClassesAbstratas.Entities
{
    class IndividualPayer : Payer
    {
        public double HealthExpenditures { get; set; }

        public IndividualPayer(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            if (AnualIncome < 20000)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }

        }

        public override string ToString()
        {
            return Name
                + ": $ "
                + Taxes().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
