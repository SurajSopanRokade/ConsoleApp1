using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Assignment2
    {
       // wc find greatest numb between 3 numbers
       public void check(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine($"{a} is greatest");
                }
                else {
                    Console.WriteLine($"{c} is greatest");
                }
            }
            else if (b > c)
            {
                Console.WriteLine($"{b} is greatest");
            }
            else
            {
                Console.WriteLine($"{c} is greatest");
            }
        }
        static void Main(string[] args)
        {
            Assignment2 a1 = new Assignment2();
            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num3");
            int num3 = Convert.ToInt32(Console.ReadLine());
            a1.check(num1, num2, num3);
        }
    }

    public class Show
    {
        // wc find greatest numb between 3 numbers
        public void check()
        {
           for(int i=1; i<=50; i++)
            {
                if(i%3==0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} Welcome to Pune");
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} Pune");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} Welcome");
                }
            }
        }
        static void Main(string[] args)
        {
            Show s = new Show();
            s.check();
        }
    }

    public class Percentage
    {
        // wc find greatest numb between 3 numbers
        public void check(int s1, int s2, int s3, int s4, int s5 )
        {
            double perc = (s1 + s2 + s3 + s4 + s5) / 5;
            if(perc >= 90)
            {
                Console.WriteLine($"perc {perc} Grade : A");
            }
            else if (perc >= 80)
            {
                Console.WriteLine($"perc {perc} Grade : B");
            }
            else if (perc >= 70)
            {
                Console.WriteLine($"perc {perc} Grade : C");
            }
            else
            {
                Console.WriteLine($"perc {perc} Grade : D");
            }
        }
        static void Main(string[] args)
        {
            Percentage s = new Percentage();
            s.check(78,90,78,89,78);
        }
    }

    public class Find
    {
       
        public void check(int a)
        {
            String s = a > 0 ? "positive" : a < 0 ? "negative" : "Zero";
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Find s = new Find();
            s.check(0);
        }
    }

    public class FindMax
    {

        public void check(int a, int b, int c)
        {
            String s = a > b ? (a > c ? $"{a} is greatest" : $"{c} is greatest") : b > c ? $"{b} is greatest" : $"{c} is greatest";
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            FindMax s = new FindMax();
            s.check(4,5,6);
        }
    }
}
