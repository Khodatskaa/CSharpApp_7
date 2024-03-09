using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_7
{
    public class CreditCardPayment : ICreditCardPayment
    {
        public void ProcessPayment(string creditCardNumber, decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C} using card number {creditCardNumber}");
        }
    }
}
