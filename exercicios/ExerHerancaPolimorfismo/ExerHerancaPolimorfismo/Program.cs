using ExerHerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int num = int.Parse(Console.ReadLine());

            List<Product> ProductsList = new List<Product>();

            for (int i=0; i<num; i++)
            {
                Console.WriteLine($"Product #{i+1} data: ");
                Console.Write("Common, userd or imported (c/u/i)? ");
                char tag = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tag == 'i')
                {
                    Console.Write("Custom fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ProductsList.Add(new ImportedProduct(name, price, customsFee));
                }

                if (tag == 'c')
                {
                    ProductsList.Add(new Product(name, price));
                }

                if (tag == 'u')
                {
                    Console.Write("Manufacture Date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    ProductsList.Add(new UsedProduct(name, price, date));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product products in ProductsList)
            {
                Console.WriteLine(products.PriceTag()); 
            }


        }
    }
}
