namespace ExerInterfaces.Services
{
    interface IPaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int month);
    }
}
