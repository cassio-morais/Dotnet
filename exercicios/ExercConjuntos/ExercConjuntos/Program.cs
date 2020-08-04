using ExercConjuntos.Entities;
using System;
using System.Collections.Generic;


namespace ExercConjuntos
{
    class Program
    {
        public static void Main()
        {

            HashSet<Studant> studantsA = new HashSet<Studant>();
            HashSet<Studant> studantsB = new HashSet<Studant>();
            HashSet<Studant> studantsC = new HashSet<Studant>();


            Console.Write("How Many students for course A: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.Write("Enter studant code: ");
                int cod = int.Parse(Console.ReadLine());
                studantsA.Add(new Studant(cod));
            }

            Console.Write("How Many students for course B: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                Console.Write("Enter studant code: ");
                int cod = int.Parse(Console.ReadLine());
                studantsB.Add(new Studant(cod));
            }


            Console.Write("How Many students for course C: ");
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                Console.Write("Enter studant code: ");
                int cod = int.Parse(Console.ReadLine());
                studantsC.Add(new Studant(cod));
            }


            HashSet<Studant> all = new HashSet<Studant>(studantsA);
            all.UnionWith(studantsB);
            all.UnionWith(studantsC);

            Console.WriteLine("Total Students: " + all.Count);

        }

    }

}
