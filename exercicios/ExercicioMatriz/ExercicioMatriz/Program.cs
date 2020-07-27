using System;


namespace ExercicioMatriz {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());

            int[,] matriz = new int[x, x];

            int negativo = 0;

            for (int linha=0; linha < x; linha++) {
                string[] numeros = Console.ReadLine().Split(" ");
                
                for (int coluna=0; coluna < x; coluna++) {
                    matriz[linha, coluna] = int.Parse(numeros[coluna]);

                    if (int.Parse(numeros[coluna]) < 0) {
                        negativo++;
                    }

                }
            }

            Console.WriteLine("Main Diagonal:");
            for (int i = 0; i < x; i++) { 
            Console.Write(matriz[i,i] + " ");
            
            }

            Console.WriteLine("\nNegative numbers: " + negativo);
        }

    }
}



