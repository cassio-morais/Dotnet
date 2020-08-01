using System;
using System.Globalization;
using System.IO;
using ExercArquivos.Entities;

namespace ExercArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var origem = @"D:\Google Drive\Dotnet\Dotnet\exercicios\ExercArquivos\ExercArquivos\arquivo.txt";
            var destino = @"D:\Google Drive\Dotnet\Dotnet\exercicios\ExercArquivos\ExercArquivos\out\summary.csv";

            try
            {
                string[] arquivoOrigem = File.ReadAllLines(origem);

                foreach (string l in arquivoOrigem)
                {
                    var linha = l.Split(',');
                    var nome = linha[0];
                    var valor = double.Parse(linha[1], CultureInfo.InvariantCulture);
                    var quant = int.Parse(linha[2], CultureInfo.InvariantCulture);
                    
                    Produto Produto = new Produto(nome, valor, quant);
                                        
                    var novaLinha =  Produto.Nome+ "," + Produto.Total().ToString("F2", CultureInfo.InvariantCulture);
                    
                    using (var arquivoDestino = File.AppendText(destino))
                    {
                        arquivoDestino.WriteLine(novaLinha);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
