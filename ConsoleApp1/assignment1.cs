using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class assignment1
    {
        //hii
        public void calculate(int r)
        {
            float pi = 3.14F;
            float area = pi * r * r;
            Console.WriteLine("Area : "+area);
        }
        static void Main(string[] args)
        {
            assignment1 a1 = new assignment1();
            a1.calculate(4);
        }
    }

    public class Swapping
    {
        public void swap(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a :"+a);
            Console.WriteLine("b :"+b);
        }
        static void Main(string[] args)
        {
            Swapping a1 = new Swapping();
            a1.swap(4,6);
        }
    }

    public class AreaTri
    {
        public void cal(int h, int b)
        {
            double area = (0.5) * h * b;
            Console.WriteLine("Area of Triangle : "+area);
        }
        static void Main(string[] args)
        {
            AreaTri a1 = new AreaTri();
            a1.cal(4, 6);
            
        }
    }

    public class Percent
    {
        public void cal(int s1, int s2, int s3, int s4, int s5)
        {
            int percent= (s1+s2+s3+s4+s5)/5;
            Console.WriteLine("Percentage : "+percent);
        }
        static void Main(string[] args)
        {
            Percent a1 = new Percent();
            a1.cal(67,89,66,56,89);
        }
    }
}
