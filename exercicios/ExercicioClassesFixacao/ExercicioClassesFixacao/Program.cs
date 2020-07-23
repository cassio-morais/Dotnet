using System;
using System.Globalization;

namespace ExercicioClassesFixacao {
    class Program {
        static void Main( ) {

            Retangulo retangulo = new Retangulo(); // instancia a classe para ter acesso aos seus atributos e métodos
            double area, perimetro, diagonal;

            Console.WriteLine("Entre a largura e altura do retângulo: ");

            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // atributos da classe tipo double
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = retangulo.Area();  // metodos implantados nas classes / retorna um double
            perimetro = retangulo.Perimetro();
            diagonal = retangulo.Diagonal();

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
