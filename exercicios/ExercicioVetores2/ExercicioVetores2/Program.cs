using System;


namespace ExercicioVetores2 {
    class Program {
        static void Main(string[] args) {

            string[] mn = Console.ReadLine().Split(" ");

            int m = int.Parse(mn[0]); // linha
            int n = int.Parse(mn[1]); // coluna

            int[,] matriz = new int[m, n];

            for (int linha = 0; linha < m; linha++) {
                string[] valores = Console.ReadLine().Split(" ");
                for (int coluna = 0; coluna < n; coluna++) {
                    matriz[linha, coluna] = int.Parse(valores[coluna]);
                }
            }

            int numero = int.Parse(Console.ReadLine());

            for (int linha = 0; linha < m; linha++) {
                for (int coluna = 0; coluna < n; coluna++) {
                    if (matriz[linha, coluna] == numero) {
                        Console.WriteLine("Position: " + linha + "," + coluna);

                        if (coluna > 0) {
                            Console.WriteLine("left: " + matriz[linha, coluna - 1]);
                        }

                        if (linha > 0) {
                            Console.WriteLine("up: " + matriz[linha - 1, coluna]);
                        }

                        if (coluna < m -1) { 
                            Console.WriteLine("right: " + matriz[linha, coluna + 1]);
                        }

                        if (linha < n - 1) {
                            Console.WriteLine("down: " + matriz[linha + 1, coluna]);
                        }


                        


                    }
                }
            }
        }
    }
}
