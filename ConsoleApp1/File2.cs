using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // this file used by programmer 2
    public partial class Calc
    {
        public void Sub(int a, int b)
        {
            int res= a - b;
            Print(res); // method hook one method get call in another
        }
        partial void Print(int c)
        {
            Console.WriteLine($"result is : {c}");
        }
    }
}
