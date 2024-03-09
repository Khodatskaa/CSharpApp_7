namespace CSharpApp_7
{
    public class Program
    {
        static void Main()
        {
            ICreditCardPayment creditCardPayment = new CreditCardPayment();
            creditCardPayment.ProcessPayment("1234-5678-9012-3456", 100.50m);

            IOnlinePayment onlinePayment = new OnlinePayment();
            ICreditCardPayment onlinePaymentAdapter = new OnlinePaymentAdapter(onlinePayment);
            onlinePaymentAdapter.ProcessPayment("9876-5432-1098-7654", 150.75m);
        }
    }
}
