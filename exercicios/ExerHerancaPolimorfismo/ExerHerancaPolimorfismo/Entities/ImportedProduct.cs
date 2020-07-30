using System.Globalization;
using System.Text;

namespace ExerHerancaPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; } // taxa de alfândega

        public ImportedProduct(string name, double price, double customsFee)
            : base (name,price) // reutiliza o construtor de Product
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag() // sobrescreve o método PriceTag de Product
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Customs Fee: $ ");
            sb.Append(CustomsFee.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(")");

            return sb.ToString();
        }

    }
}
