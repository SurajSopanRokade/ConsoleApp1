using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // this file used by programmer 1
    public partial class Calc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        partial void Print(int c);    
    }
}
