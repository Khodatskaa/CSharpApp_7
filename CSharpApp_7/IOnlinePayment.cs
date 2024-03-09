using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_7
{
    public interface IOnlinePayment
    {
        void MakePayment(string username, decimal amount);
    }
}
