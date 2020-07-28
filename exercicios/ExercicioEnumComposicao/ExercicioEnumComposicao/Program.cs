using ExercicioEnumComposicao.Entities;
using ExercicioEnumComposicao.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioEnumComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            // enum não precisa necessariamente estanciar, vc usa um parse para ele.

            Client client = new Client(name, email, birthdate);
            Order Order = new Order(DateTime.Now, status, client); 

            // Order instanciado fora do FOR pra não gerar nova Order. 
            // Sendo assim ele 'apenda' os produtos a um mesmo pedido (Order)


            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
     
    
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product Product = new Product(productName, price); 
                OrderItem Item = new OrderItem(quantity, price, Product);
               
                
                Order.AddItem(Item); // add o Item ao pedido (Order) instanciado.

            }

            Console.WriteLine();
            Console.WriteLine(Order);


        }
    }
}
