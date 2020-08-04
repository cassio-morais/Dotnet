using ExerInterfaces.Entities;
using System;

namespace ExerInterfaces.Services
{
    class ContractService
    {

        private readonly IPaymentService _PaymentService;

        public ContractService(IPaymentService paymentService)
        {
            _PaymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int quantInstallment)
        {
            double InitialAmount = contract.TotalValue / quantInstallment;

            for (int i = 1; i <= quantInstallment; i++)
            {

                DateTime dueDate = contract.Date.AddMonths(i);
                double amountWithInterest = InitialAmount + _PaymentService.Interest(InitialAmount, i);
                double finalAmount = amountWithInterest + _PaymentService.PaymentFee(amountWithInterest);

                Installment installment = new Installment(dueDate, finalAmount);

                contract.AddInstallments(installment);
                // método criado na classe Contract pra vincular a parcela ao objeto instanciado
            }

        }


    }
}
