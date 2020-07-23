using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.IO;
using System.Xml.Schema;

namespace exercicios_if_else {
    class Program {
        static void Main() {

            //exercicio 01

            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 0) {
                Console.WriteLine("NÃO NEGATIVO");
            } else {
                Console.WriteLine("NEGATIVO");
            }


            //exercicio 02

            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine("PAR");
            } else {
                Console.WriteLine("IMPAR");
            }


            //exercicio 03

            Console.WriteLine("digite um número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite outro número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 % numero2 == 0 || numero2 % numero1 == 0) {
                Console.WriteLine("São Múltiplos!");
            } else {
                Console.WriteLine("Não são múltiplos");
            }


            //jeito que eu havia feito

            if (numero1 > numero2) {
                if (numero1 % numero2 == 0) {
                    Console.WriteLine("São Múltiplos!");
                } else {
                    Console.WriteLine("Não são multiplos!");
                }
            } else if (numero2 > numero1) {
                if (numero2 % numero1 == 0) {
                    Console.WriteLine("São Múltiplos!");
                } else {
                    Console.WriteLine("Não são multiplos!");
                }
            } else {
                Console.WriteLine("São Múltiplos");
            }


           // exercicio 04

            Console.WriteLine("Digite a hora inicial e final da partida: ");
            string[] duracao = Console.ReadLine().Split(" ");
            int horaInicial = int.Parse(duracao[0]);
            int horaFinal = int.Parse(duracao[1]);

            if (horaInicial == horaFinal) {
                Console.WriteLine("O jogo durou 24 hora(s)");
            } else if (horaInicial < horaFinal) {
                Console.WriteLine($"O jogo durou {horaFinal - horaInicial} hora(s)");
            } else {
                int hora = (24 - horaInicial) + horaFinal;
                Console.WriteLine($"O jogo durou {hora} hora(s)");
            }


            // exercicio 05

            double[] precos = { 4.00, 4.50, 5.00, 2.00, 1.50 };
            Console.WriteLine("Digite o código do produto e quantidade: ");
            string[] dadosProduto = Console.ReadLine().Split(" ");
            int codProduto = int.Parse(dadosProduto[0]) - 1;
            int quantProduto = int.Parse(dadosProduto[1]);


            double total = quantProduto * precos[codProduto];

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));



            // exercicio 06

            Console.WriteLine("Digite um valor qualquer: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if ((valor >= 0.0) && (valor <= 25.0)) {
                Console.WriteLine("Intervalo [0,25]");

            } else if ((valor > 25) && (valor <= 50)) {
                Console.WriteLine("Intervalo [25,50]");
            } else if ((valor > 50) && (valor <= 75)) {
                Console.WriteLine("Intervalo [50,75]");
            } else if ((valor > 75) && (valor <= 100)) {
                Console.WriteLine("Intervalo [50,75]");
            } else {
                Console.WriteLine("Fora do intervalo");
            }

            // exercicio 07

            Console.WriteLine("Digite o valor do eixo X e do eixo Y:");

            string[] eixos = Console.ReadLine().Split();

            double X = double.Parse(eixos[0], CultureInfo.InvariantCulture);
            double Y = double.Parse(eixos[1], CultureInfo.InvariantCulture);


            if (X == 0 && Y == 0) {
                Console.WriteLine("Origem");
            } else if (Y == 0) {
                Console.WriteLine("Eixo Y");
            } else if (X == 0) {
                Console.WriteLine("Eixo X");
            } else if (X > 0 && Y > 0) {
                Console.WriteLine("Q1");
            } else if (X > 0 && Y < 0) {
                Console.WriteLine("Q4");
            } else if (X < 0 && Y > 0) {
                Console.WriteLine("Q2");
            } else if (X < 0 && Y < 0) {
                Console.WriteLine("Q3");
            }


            // exercicio 08

            Console.WriteLine("Digite o valor do salário para o calculo do imposto: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0 && salario <= 2000) {

                Console.WriteLine("Isento");

            } else if (salario > 2000 && salario <= 3000) {

                double imposto8 = (salario - 2000) * 0.08;
                Console.WriteLine("R$ " + imposto8.ToString("F2", CultureInfo.InvariantCulture));

            } else if (salario > 3000 && salario <= 4500) {

                double imposto8 = 1000 * 0.08;
                double imposto18 = (salario - 3000) * 0.18;
                double impostoTotal = imposto8 + imposto18;
                Console.WriteLine("R$ " + impostoTotal.ToString("F2", CultureInfo.InvariantCulture));

            } else if (salario > 4500) {

                double imposto8 = 1000 * 0.08;
                double imposto18 = 1500 * 0.18;
                double imposto28 = (salario - 4500) * 0.28;
                double impostoTotal = imposto8 + imposto18 + imposto28;

                Console.WriteLine("R$ " + impostoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }










        }
    }
}
