using System;
using System.Globalization;

namespace ExercicioContaBancaria {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o títular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (S/N) ");
            string depositar = Console.ReadLine().ToLower();

            if (depositar == "s") {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numConta, titular, depositoInicial);
            } else {
                conta = new ContaBancaria(numConta, titular);
            }

            Console.WriteLine("Dados da Conta");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da Conta atualizados: ");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da Conta atualizados: ");
            Console.WriteLine(conta);

            

        }
    }
}
