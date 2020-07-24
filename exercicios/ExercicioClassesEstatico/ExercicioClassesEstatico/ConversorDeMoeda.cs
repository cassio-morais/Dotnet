using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioClassesEstatico {
    class ConversorDeMoeda {

        // public para ser acessado fora da classe
        // static pq é um método da classe, não precisa de instância para ser usada

        public static double Iof = 0.06; // variavel static de uso da classe
        public static double Conversor(double dolar, double quantDolar) {

            dolar = dolar + (dolar * Iof);
            return dolar * quantDolar;
        }

    }
}
