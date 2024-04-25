using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class InterviewPract
    {
        /* 1. write a code which contain one abstract class. abstract class having one variable is of integer type.
              create one interface which also contain variable is of integer type perform addition of two variables in
              child class.*/

        public int a { get; set; }



    }
    public interface ITestable
    {
        public static int b;

    }
    public class Child : InterviewPract, ITestable
    {
       

        public void addition()
        {
            int sum = a + ITestable.b;
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
           Child c= new Child();
            c.a = 1;
            ITestable.b = 2;
            c.addition();
        }

    }
}
