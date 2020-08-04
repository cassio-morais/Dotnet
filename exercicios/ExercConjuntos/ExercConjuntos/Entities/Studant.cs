using System;

namespace ExercConjuntos.Entities
{
    class Studant
    {
        public int CodStudant { get; set; }

        public Studant()
        {

        }

        public Studant(int codEstudante)
        {
            CodStudant = codEstudante;
        }

        // Objetos não implementam diretamente gethashcode e equals
        // é necessário sobrescrever os metodos senão qualquer comparação
        // será tratada a nível de posição na memória de objeto. 
        // tipos primitivos, struts... já implementam essa interface por padrão

        public override int GetHashCode()
        {
            return CodStudant.GetHashCode(); // gerar hashcode para o codstudant
        }

        public override bool Equals(object obj)
        {
            var other = obj as Studant; // downcasting de object obj para estudant obj
            return CodStudant.Equals(other.CodStudant); // comparar pelo cod studant
        }


    }
}
