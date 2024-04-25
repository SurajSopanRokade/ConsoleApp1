using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Prime
    {
        public void check(int n)
        {
            int count = 0;
            for(int j = 2; j < n/2; j++)
            {
              if(n/j==0)
              {
                count++;
              }
            }
            if (count == 0)
            {
                Console.WriteLine("Number is prime number");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }           
        }

        static void Main(string[] args)
        {
              Prime p = new Prime();
              p.check(10);
        }
    }

    
}
