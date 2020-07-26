using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVetores {
    class Renter {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public override string ToString() {
            return Room + ":" + Name + "," + Email;
        }


        // como o professor implantou


        //class Estudante {
        //    public string Nome { get; set; }
        //    public string Email { get; set; }
        //    public Estudante(string nome, string email) {
        //        Nome = nome;
        //        Email = email;
        //    }
        //    public override string ToString() {
        //        return Nome + ", " + Email;
        //    }
        //}


    }
}
