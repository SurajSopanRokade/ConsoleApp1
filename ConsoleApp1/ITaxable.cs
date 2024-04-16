using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ITaxable1
    {
        double PayTax();  // public, abstract, virtual
    }
    //implicite implement of interface

    public class Job : ITaxable1
    {
        private double salary;
        private double taxamount;

        public Job(double salary) {
            this.salary = salary;
        }
        public double PayTax()
        {
            taxamount = salary * 0.20;
            return taxamount;
        }
    }

    public class Business : ITaxable1
    {
        private double salary;
        private double taxamount;

        public Business(double salary)
        {
            this.salary = salary;
        }
        public double PayTax()
        {
            taxamount = salary * 0.30;
            return taxamount;
        }
    }
}
