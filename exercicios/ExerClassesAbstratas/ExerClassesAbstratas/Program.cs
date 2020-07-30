using System;
using System.Collections.Generic;
using System.Globalization;
using ExerClassesAbstratas.Entities;

namespace ExerClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> TaxPayers = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company: ");
                char PayerType = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (PayerType == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    TaxPayers.Add(new IndividualPayer(name, anualIncome, health));
                }

                if (PayerType == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    TaxPayers.Add(new CompanyPayer(name, anualIncome, employees));
                }
            }


            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double totalTaxes = 0;
            foreach (Payer payer in TaxPayers)
            {
                Console.WriteLine(payer.ToString());
                totalTaxes += payer.Taxes();
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
