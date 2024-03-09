using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_7
{
    public class OnlinePaymentAdapter(IOnlinePayment onlinePayment) : ICreditCardPayment
    {
        private readonly IOnlinePayment onlinePayment = onlinePayment;

        public void ProcessPayment(string creditCardNumber, decimal amount)
        {
            string username = GetUsernameFromCreditCard(creditCardNumber);
            onlinePayment.MakePayment(username, amount);
        }

        private static string GetUsernameFromCreditCard(string creditCardNumber)
        {
            if (creditCardNumber is null)
            {
                throw new ArgumentNullException(nameof(creditCardNumber));
            }

            return "JohnDoe";
        }
    }
}
