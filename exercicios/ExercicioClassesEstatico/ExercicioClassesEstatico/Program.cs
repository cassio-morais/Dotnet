using System;
using System.Globalization;

namespace ExercicioClassesEstatico {
    class Program {
        static void Main() {

            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Reais = ConversorDeMoeda.Conversor(dolar, quantDolar);

            Console.Write("Valor a ser pago em reais = " + Reais.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
