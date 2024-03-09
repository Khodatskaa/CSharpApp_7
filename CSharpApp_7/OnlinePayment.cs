using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_7
{
    public class OnlinePayment : IOnlinePayment
    {
        public void MakePayment(string username, decimal amount)
        {
            Console.WriteLine($"Processing online payment of {amount:C} for user {username}");
        }
    }
}
