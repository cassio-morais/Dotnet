using System;
using System.Globalization;
using ExerInterfaces.Entities;
using ExerInterfaces.Services;


namespace ExerInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int quantInstallments = int.Parse(Console.ReadLine());


            // instancia o contrato
            Contract Contract = new Contract(number, date, totalValue);


            // instancia um ContractService passando o serviço de pagamento 
            // esse serviço de pagamento implementa uma interface
            ContractService ContractService = new ContractService(new PayPalService());


            // processa o contrato passando o mesmo e a quantidade de parcelas (installments)
            // ele modifica a lista de installments acrescentando as parcelas
            ContractService.ProcessContract(Contract, quantInstallments);


            Console.WriteLine("Installments: ");
            foreach (Installment installment in Contract.Installments)
            {
                Console.Write(installment.DueDate.ToString("dd/MM/yyyy"));
                Console.Write(" - ");
                Console.WriteLine(installment.Amount.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
