using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculation
    {
        //method overloading
        public int Addition(int a , int b)
        {
            return a + b;
        }
        public int Addition(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Addition(int a , double b)
        {
            return a + b;
        }

        // different parameter list 
        //1. no. of parameters should be different
        //2 if no. of parameters are same then datatype should be different

    }
    public class Maths
    {
        private const double pi = 3.14; // we cannot modify the value. compulsory add value to variable
        private readonly int max;

        public Maths()
        {
            max = 120;
        }

        public void Test()
        {
            // pi=3.45;
            // max = 100;
            const int min = 0; // const allowed in method as local variable
            //readonly not allowed. it must be a datamember
        }

    }
}
