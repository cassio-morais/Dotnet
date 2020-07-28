using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ExercicioEnumComposicao.Entities.Enums;

namespace ExercicioEnumComposicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; } // enum 
        public Client Client { get; set; } // tipo Client da classe Client
        public List<OrderItem> Item { get; set; } = new List<OrderItem>(); // tipo OrderItem da Classe OrderItem

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item) // recebe um elemento tipo lista
        {
            Item.Add(item); // Item vai receber os valores descritos na classe OrderItem
                            // OrderItem - int quantity, double price, Product product
        }

        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Item) // para cada item da lista de items
            {
                sum += item.SubTotal(); // soma recebe o retorno de SubTotal que é quantidade * preço 
            }                           // que é um método que fica em OrdemItem
            return sum;
        }

        
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("ORDER SUMARY");
            stringBuilder.Append("Order Moment: ");
            stringBuilder.AppendLine(Moment.ToString());
            stringBuilder.Append("Status: ");
            stringBuilder.AppendLine(OrderStatus.ToString());
            stringBuilder.Append(Client.ToString());
            stringBuilder.AppendLine("Order items: ");
            
            foreach (OrderItem item in Item) // listando cada item na lista de pedidos (OrderItem)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            stringBuilder.AppendLine("Total Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return stringBuilder.ToString();
            

        }

    }
}
