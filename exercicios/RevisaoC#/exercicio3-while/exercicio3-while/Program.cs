using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace exercicio3_while {
    class Program {
        static void Main(string[] args) {

            // exercicio 01

            int senha = 2002;
            int senhaDigitada = 0;

            while (senhaDigitada != senha) {

                Console.WriteLine("Digite sua senha");
                senhaDigitada = int.Parse(Console.ReadLine());

                if (senhaDigitada != senha) {
                    Console.WriteLine("Senha Inválida");
                }
            }

            Console.WriteLine("Acesso permitido");


            // exercicio 02


            double X = -10;
            double Y = -20;

            while (X != 0 && Y != 0) {

                Console.WriteLine("Digite o valor do eixo X e do eixo Y:");

                string[] eixos = Console.ReadLine().Split();

                X = double.Parse(eixos[0], CultureInfo.InvariantCulture);
                Y = double.Parse(eixos[1], CultureInfo.InvariantCulture);

                if (X > 0 && Y > 0) {
                    Console.WriteLine("primeiro");
                } else if (X > 0 && Y < 0) {
                    Console.WriteLine("quarto");
                } else if (X < 0 && Y > 0) {
                    Console.WriteLine("segundo");
                } else if (X < 0 && Y < 0) {
                    Console.WriteLine("terceiro");
                }

            }


            // exercicio 03

            Console.WriteLine("Qual foi o combustível abastecido: 1 - álcool | 2 - Gasolina | 3 - Diesel | 4 - Fim");

            int opcao = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (opcao != 4) {

                if (opcao == 1) {
                    alcool++;
                }
                else if(opcao == 2){
                    gasolina++;
                } 
                else if(opcao == 3){
                    diesel++;
                } 
                Console.WriteLine("Qual foi o combustível abastecido: 1 - álcool | 2 - Gasolina | 3 - Diesel | 4 - Fim");
                opcao = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
