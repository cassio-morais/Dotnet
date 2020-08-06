using System;
using System.Linq;
using LINQLambda.Entities;
using System.Collections.Generic;

namespace LINQLambda
{
    class Program
    {
        // o tipo de T (Generics) é passado por inferencia quando é declarado o objeto
        static void Print<T>(string message, IEnumerable<T> collection)
        {

            Console.WriteLine(message);

            foreach (T element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            // objetos de categoria
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };


            // objeto produtos com categoria relacionada
            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };


            var result1 = products // IEnumerable de produtos 
                .Where(product => product.Price < 900 && product.Category.Tier == 1);
            // product é o elemento dentro da lista de produtos, poderia ser qualquer outro nome

            Print("PREÇO MENOR QUE 900 E CATEGORIA TIER 1:", result1); // usando método auxiliar


            var result2 = products
                .Where(p => p.Category.Name == "Tools")
                .Select(p => p.Name);

            Print("NOME DOS PRODUTOS NA CATEGORIA TOOLS: ", result2);


            var result3 = products
                .Where(prod => prod.Name[0] == 'C')   // selecionando produtos que começam com C
                .Select(prod => new { prod.Name, prod.Price, CategoryName = prod.Category.Name });
            // criando um objeto anonimo 'new'        //atribuindo um alias pra não gerar problema com o outro Name

            Print("PRODUTOS QUE COMEÇAM COM A LETRA 'C'", result3);


            var result4 = products
                .Where(p => p.Category.Tier == 1)
                .OrderBy(p => p.Price) // ordenados pelo preço
                .ThenBy(p => p.Name); // se empatar, ordenado pelo nome

            Print("TIER 1 ORDENADO POR PREÇO E POR NOME", result4);

            var result5 = result4 // aproveitando o resultado anterior
                .Skip(2)
                .Take(4); // pula 2 e pega 4, muito usado para paginção

            Print("TIER 1 ORDENADO POR PREÇO E POR NOME PULANDO 2 E PEGANDO 4", result5);

            var result6 = products.Where(p => p.Price > 5000.0).FirstOrDefault();

            Console.WriteLine("SE NÃO ACHAR O PRIMEIRO, RETORNA O VALOR PADRÃO OU NULO: " + result6);


            // -----------------------------------------------------------------------------------------------------------

            Console.WriteLine();
            var result7 = products.Max(p => p.Price); // 

            Console.WriteLine("MAX PRICE: " + result7);



            var result8 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price); 

            Console.WriteLine("PREÇOS SOMADOS DA CATEGORIA 1: " + result8); // 240


            var result9 = products.Where(p => p.Category.Id == 1).Average(p => p.Price); 

            Console.WriteLine("MÉDIA DE PREÇOS DA CATEGORIA 1: " + result9);

            var result10 = products
                .Where(p => p.Category.Id == 5)
                .Select(p => p.Price)
                .DefaultIfEmpty(0.0)
                .Average(); 
            // se não existir, retorna o valor padrão.

            Console.WriteLine("MÉDIA DE PREÇOS DA CATEGORIA 5: " + result10); // 0


            //------------------------------------------------------------------------------------------------------------

            // agreggate "reduce em outras linguagens"

            var result11 = products
                .Where(p => p.Category.Id == 1)
                .Select(p => p.Price)
                .Aggregate(0.0 ,(x, y) => x + y); // recebe x e y e retorna a soma (recebe valor inicial 0.0)

            Console.WriteLine("PREÇOS SOMADOS COM AGGREGATE DA CATEGORIA 1: " + result11); // 240
            Console.WriteLine();

            // group by
            var result12 = products.GroupBy(p => p.Category);

            foreach (IGrouping<Category,Product> group in result12) // poderia usar var
            {
                Console.WriteLine("CATEGORIA " + group.Key.Name + ":"); // indexador do objeto (agrupamento)

                foreach (var prod in group) // extensões dos objetos (elementos do grupo)
                {
                    Console.WriteLine(prod);
                }
            }

        }
    }
}
