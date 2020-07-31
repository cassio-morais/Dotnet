using ExerTratamentoExcecoes.Entities;
using ExerTratamentoExcecoes.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExerTratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter Account Data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number,holder,balance,withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                account.Withdraw(amount);
                Console.WriteLine("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }

            catch(DomainException e) // exceções criadas por mim na classe Account
            {
                Console.WriteLine(e.Message); 
            }
            catch(Exception e)  // exceções genéricas de sistema da classe Exception
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
