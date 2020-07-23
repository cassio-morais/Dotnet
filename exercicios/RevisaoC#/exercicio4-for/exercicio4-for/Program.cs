using System;
using System.Globalization;


namespace exercicio4_for {
    class Program {
        static void Main(string[] args) {


            // exercicio 01 

            Console.Write("número: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }


            // exercicio 02


            Console.Write("Quantos serão lidos: ");
            int lidos = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;

            for (int i = 1; i <= lidos; i++) {
                Console.Write("Digite o número: ");
                int n = int.Parse(Console.ReadLine());

                if (n >= 10 && n <= 20) {
                    dentro++;
                } else {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");


            // exercicio 03

            Console.Write("Quantos casos  de teste? ");
            int teste = int.Parse(Console.ReadLine());


            for (int i = 1; i <= teste; i++) {

                string[] numeros = Console.ReadLine().Split(' ');
                double v1 = double.Parse(numeros[0], CultureInfo.InvariantCulture) * 2.0;
                double v2 = double.Parse(numeros[1], CultureInfo.InvariantCulture) * 3.0;
                double v3 = double.Parse(numeros[2], CultureInfo.InvariantCulture) * 4.0;

                double mediaPonderada = (v1 + v2 + v3) / (2.0 + 3.0 + 4.0);

                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }


            // exercicio 04


            Console.Write("Quantos pares para dividir? ");

            int pares = int.Parse(Console.ReadLine());
            double divisao = 0;

            for (int i = 1; i <= pares; i++) {

                string[] div = Console.ReadLine().Split(' ');
                int numerador = int.Parse(div[0]);
                int denominador = int.Parse(div[1]);

                if (denominador == 0) {
                    Console.WriteLine("divisao impossivel");
                } else {
                    divisao = (double)numerador / (double)denominador;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }


            // exercicio 05

            Console.Write("Digite o número que deseja fatorar: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0 || numero == 1) {
                Console.WriteLine(1);
            } else {
                int fatorial = numero;
                for (int f = 1; f <= numero; f++) {
                    fatorial = fatorial * (numero - 1);
                    numero--;
                }
                Console.WriteLine(fatorial);
            }


            // exercicio 06

            Console.WriteLine("Entre com um numero inteiro para calcular todos seus divisores: ");
            int numInt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numInt; i++) {
                if (numInt % i == 0) {
                    Console.WriteLine(i);
                }
            }


            // exercicio 07

            Console.WriteLine("mais um numero: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                Console.Write(i + " ");
                Console.Write(Math.Pow(i, 2) + " ");
                Console.Write(Math.Pow(i, 3));
                Console.WriteLine();
            }

        }
    }
}
