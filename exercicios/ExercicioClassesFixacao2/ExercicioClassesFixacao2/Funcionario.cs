using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioClassesFixacao2 {
    class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }


        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0); 
            // como altera apenas um valor de um atributo da classe, não retorna nada.
        }


        // sobrescreve o método ToString da classe Object de qual qualquer classe em C# herda
        // parecido com o __repr__ de Python. 
        public override string ToString() {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
