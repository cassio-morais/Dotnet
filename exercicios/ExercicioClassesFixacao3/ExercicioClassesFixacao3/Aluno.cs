using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioClassesFixacao3 {
    class Aluno {

        public string Nome;
        public double Nota1, Nota2, Nota3;
  

        public double NotaFinal() { 
            return Nota1 + Nota2 + Nota3;
        }

        public string Status() {
            if (NotaFinal() >= 60.0) {
                return "APROVADO";
            } else {
                return "REPROVADO";
            }
        }


        //// como o professor implantou 


        //public double Nota1, Nota2, Nota3;
        //public double NotaFinal() {
        //    return Nota1 + Nota2 + Nota3;
        //}
        //public bool Aprovado() {
        //    if (NotaFinal() >= 60.0) {
        //        return true;
        //    } else {
        //        return false;
        //    }
        //}
        //public double NotaRestante() {
        //    if (Aprovado()) {
        //        return 0.0;
        //    } else {
        //        return 60.0 - NotaFinal();
        //    }





        }
}
