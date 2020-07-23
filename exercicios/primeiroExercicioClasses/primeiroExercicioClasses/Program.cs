using System;
using System.Globalization;

namespace primeiroExercicioClasses {
    class Program {
        static void Main() {

            // exercicio 01

            Pessoa pessoa1 = new Pessoa(); // declaro meu objeto do tipo Pessoa que criei e instancio ao mesmo tempo
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade) {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            } else {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            }


            // exercicio 02

            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();


            Console.WriteLine("Dados da primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("salario: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("salario: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2.0;

            Console.WriteLine("Salário Médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));





        }
    }
}
