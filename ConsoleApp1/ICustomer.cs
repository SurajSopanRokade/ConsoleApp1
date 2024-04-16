using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICustomer
    {
        string Print();
    }
    public interface IOrder
    {
        string Print();
    }

    public class Transaction : ICustomer, IOrder
    {
        // access specifier bydefault public
        string ICustomer.Print()
        {
            return "Customer details";
        }

        string IOrder.Print()
        {
            return "Order details";
        }
    }
}
