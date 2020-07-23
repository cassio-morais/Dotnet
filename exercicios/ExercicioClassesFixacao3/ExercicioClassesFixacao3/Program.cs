using System;
using System.Globalization;

namespace ExercicioClassesFixacao3 {
    class Program {
        static void Main() {

            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(aluno.Status());

            if (aluno.NotaFinal() < 60.0) {
                double notaFaltante = 60.0 - aluno.NotaFinal();
                Console.WriteLine("FALTARAM " + notaFaltante.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }





        }
    }
}
