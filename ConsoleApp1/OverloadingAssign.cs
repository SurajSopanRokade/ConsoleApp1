using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OverloadingAssign
    {
      /*  1. wc to show the overloading of calculate method.calculate area of rectangle, triangle, circle, square
        use menu driven concept.*/

        public void calculatearea(int l, int b)
        {
            int area = l * b;
            Console.WriteLine("Area of reactangle is : "+area);
        }
        public void calculatearea(double b, double h)
        {
            double area =0.5* h * b;
            Console.WriteLine("Area of triangle : " + area);
        }
        public void calculatearea(double radius)
        {
            double area = 3.14*radius * radius;
            Console.WriteLine("Area of circle : " + area);
        }
        public void calculatearea(int side)
        {
            double area = side * side;
            Console.WriteLine("Area of square : " + area);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Calculate area of rectangle press 1 " +
                "Area of triangle press 2 " +
                "Area of circle press 3 " +
                "area of square press 4 ");
            int a = Convert.ToInt32(Console.ReadLine());
            OverloadingAssign o = new OverloadingAssign();

            switch (a)
            {
                case 1:
                    Console.WriteLine("Enter length");
                    int l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter breadth");
                    int b = Convert.ToInt32(Console.ReadLine());
                    o.calculatearea(l, b);
                    break;

                case 2:
                    Console.WriteLine("Enter height");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter base");
                    double br = Convert.ToDouble(Console.ReadLine());
                    o.calculatearea(h, br);
                    break;

                case 3:
                    Console.WriteLine("Enter radius");
                    double r = Convert.ToDouble(Console.ReadLine());
                    o.calculatearea(r);
                    break;

                case 4:
                    Console.WriteLine("Enter side");
                    int s = Convert.ToInt32(Console.ReadLine());
                    o.calculatearea(s);
                    break;
            }
        }

        

    }

    public class OverloadingAssign2
    {
        //2. wc to overload the static method to calculate the all the arithmetic operations.

        public static void cal (int a, int b)
        {
            int addition = a + b;
            Console.WriteLine("Addition : "+addition);
        }
        public static void cal(double a, double b)
        {
            double multi = a * b;
            Console.WriteLine("Multi : " + multi);
        }
        public static void cal(double a, int b)
        {
            double divi = a / b;
            Console.WriteLine("division : " + divi);
        }
        public static void cal(int a, double b)
        {
            double sub = a - b;
            Console.WriteLine("substraction : "+sub);
        }

        static void Main(string[] args)
        {
            OverloadingAssign2 o1=  new OverloadingAssign2();
            Console.WriteLine("Addition press 1 " +
               "Multiplication press 2 " +
               "Division press 3 " +
               "substraction press 4 ");
            int a = Convert.ToInt32(Console.ReadLine());
           

            switch (a)
            {
                case 1:
                    Console.WriteLine("Enter num1");
                    int l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter num2");
                    int b = Convert.ToInt32(Console.ReadLine());
                    cal(l, b);
                    break;

                case 2:
                    Console.WriteLine("Enter num1");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter num2");
                    double br = Convert.ToDouble(Console.ReadLine());
                    cal(h, br);
                    break;

                case 3:
                    Console.WriteLine("Enter num1");
                    double h1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter num2");
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    cal(h1, b1);
                    break;

                case 4:
                    Console.WriteLine("Enter num1");
                    int h2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter num2");
                    double b2 = Convert.ToDouble(Console.ReadLine());
                    cal(h2, b2);
                    break;
            }
        }

    }

    public class StaticAssign
    {
        public static int count;
       // 3. wc to demonstrait static keyword with variable, method, constructor and class.
        public StaticAssign()
        {
            count++;
            Console.WriteLine("Count : "+count);
        }

        static void Main(string[] args)
        {
            StaticAssign s1 = new StaticAssign();
            StaticAssign s2 = new StaticAssign();
        }
    }


}
