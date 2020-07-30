using System;
using System.Globalization;
using System.Text;

namespace ExerHerancaPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufacturedate) 
            : base(name, price) // reutiliza o construtor de Product
        {
            ManufactureDate = manufacturedate;
        }

        public override string PriceTag() // sobrescreve o método PriceTag de Product
        {   
            StringBuilder sb = new StringBuilder();

            sb.Append(Name);
            sb.Append(" (used) $ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Manufacture date:) ");
            sb.Append(ManufactureDate.ToString("dd/MM/yyyy"));

            return sb.ToString();

        
        }

    }

    
}
