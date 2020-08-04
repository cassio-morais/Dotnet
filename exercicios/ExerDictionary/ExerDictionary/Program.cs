using System;
using System.Collections.Generic;
using System.IO;

namespace ExerDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the full path: ");
            var path = Console.ReadLine();

            try
            {

                using (var reader = File.OpenText(path)) // StreamReader reader
                {

                    Dictionary<string, int> Candidates = new Dictionary<string, int>();
                    while (!reader.EndOfStream)
                    {
                        var linha = reader.ReadLine().Split(",");
                        var candidate = linha[0];
                        var votes = int.Parse(linha[1]);

                        if (Candidates.ContainsKey(candidate))
                        {
                            Candidates[candidate] += votes;
                        }

                        else
                        {
                            Candidates[candidate] = votes;
                        }

                    }

                    foreach (var item in Candidates)
                    {
                        Console.WriteLine(item.Key + " : " + item.Value);

                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }

        }
    }
}
