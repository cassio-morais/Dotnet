using System;

namespace ExercicioVetores {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many rooms will be rented? ");
            int rooms = int.Parse(Console.ReadLine());

            // instanciando um vetor de objetos da classe Renter
            Renter[] renters = new Renter[10]; 

            for (int i=0; i < rooms; i++) {
                Console.WriteLine("Rent #"+(i+1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                renters[room] = new Renter { Name = name, Email = email, Room = room }; // não criei método construtor
                Console.WriteLine();
            }



            Console.WriteLine("Busy rooms: ");
            for (int r=0; r < renters.Length; r++) { 
                if (renters[r] != null) {
                    Console.WriteLine($"{renters[r].Room}: {renters[r].Name}, {renters[r].Email}"); // EXPLÍCITO 
                }
            }


        }
    }
}
