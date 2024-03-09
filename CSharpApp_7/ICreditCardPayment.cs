using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_7
{
    public interface ICreditCardPayment
    {
        void ProcessPayment(string creditCardNumber, decimal amount);   //decimal is a 128-bit data type suitable for financial and monetary calculations
    }
}
