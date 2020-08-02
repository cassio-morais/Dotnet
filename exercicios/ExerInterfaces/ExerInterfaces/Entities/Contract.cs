using System;
using System.Collections.Generic;

namespace ExerInterfaces.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
            // Cria uma lista vazia do tipo Installment (parcelas),
            // apenas aguardando a injeção vinda de outra classe
            // usando o metodo addInstallments (parcelas)
        }


        public void AddInstallments(Installment installment)
        {
            Installments.Add(installment);
        }

    }
}
