using System;
using System.Collections.Generic;
using System.Text;

namespace ExerInterfaces.Entities
{
    class Installment // parcelas
    {
        public DateTime DueDate { get; set; } // data de vencimento
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
