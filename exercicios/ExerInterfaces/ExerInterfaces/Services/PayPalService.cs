
namespace ExerInterfaces.Services
{
    class PayPalService : IPaymentService
    {
        const double MonthlySimpleInterest = 0.01;
        const double Fee = 0.02;


        public double PaymentFee(double amount)
        {
            return amount * Fee;

        }

        public double Interest(double amount, int month)
        {

            return amount * MonthlySimpleInterest * month;
        }

    }
}
