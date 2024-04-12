using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Addition
    {
        // main is not public method
        // Main () M is capital letter
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int c = num1 + num2;
            Console.WriteLine($"Addition is {c}");
        }

    }

    public class findNumberEvenOrOdd
    {
        public void check(int a)
        {
            if (a%2==0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd"); ;
            }
        }
        static void Main(string[] args)
        {
            findNumberEvenOrOdd f = new findNumberEvenOrOdd();
            f.check(1);

        }

    }


    public class findNumberPrime
    {
       
        public void check(int a)
        {
            int count = 0;
               for (int j = 2; j < a/2; j++)
                {
                    if(a%j==0)
                {
                    count++;
                }
                }
            if (count == 0)
            {
                Console.WriteLine($"{a} is prime number");
            }
            else
            {
                Console.WriteLine($"{a} is not prime number");
            }
            
        }
        static void Main(string[] args)
        {
            findNumberPrime f = new findNumberPrime();
            f.check(16);

        }

    }

    public class findNumberPalendrome
    {
        public void check(int a)
        {
            int original = a;
            int c = 0;
            while (a != 0)
            {
                int rem = a % 10;
                c = c * 10 + rem;
                a = a / 10;
            }
            if(original==c)
            {
                Console.WriteLine($"{original} Number is palendrome");
            }
            else
            {
                Console.WriteLine($"{original} Number is not palendrome");
            }
        }
        static void Main(string[] args)
        {
            findNumberPalendrome f = new findNumberPalendrome();
            f.check(12321);

        }

    }

    public class Factorial
    {

        public void facto(int a)
        {
            int fact = 1;
            while(a != 0)
            {
                fact = fact * a;
                a = a - 1;
            }
            Console.WriteLine(fact);
        }
        static void Main(string[] args)
        {
            Factorial f = new Factorial();
            f.facto(5);

        }

    }

    public class Freq
    {

        public void frequency(int a)
        {
       
            for ( int i=1; i<=9; i++)
            {
                int count = 0;
                int temp = a;
                while(temp != 0)
                {
                    int rem = temp % 10;

                    if (i == rem)
                    {
                        count++;
                    }
                    temp = temp / 10;
                }
                if(count!=0)
                Console.WriteLine($" frequency of number {i} is {count}");
            }
        }
        static void Main(string[] args)
        {
            Freq f = new Freq();
            f.frequency(53344);

        }

    }

    public class Max
    {

        public void maxdigit(int a)
        {
            int max = 0;
            while(a>0) {
                int rem = a % 10;
                if(rem > max)
                {
                    max = rem;
                }
                a = a / 10;
            }
            Console.WriteLine("max digit is : "+max);
        }
        static void Main(string[] args)
        {
            Max f = new Max();
            f.maxdigit(53344);

        }

    }

    public class Power
    {

        public void power(int ex, int b)
        {
            int pow = 1;
            for(int i=1; i<=ex;i++)
            {
                pow = pow * b;
            }
            Console.WriteLine("Power : "+pow);
        }
        static void Main(string[] args)
        {
            Power f = new Power();
            f.power(2,3);

        }

    }

    public class Sum
    {

        public void sum(int a)
        {
            int sum = 0;
            for( int i=1; i<=a; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum : "+sum);
        }
        static void Main(string[] args)
        {
            Sum f = new Sum();
            f.sum(4);

        }

    }

    public class Mult
    {

        public void multi(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Multi : "+c);
        }
        static void Main(string[] args)
        {
            Mult f = new Mult();
            f.multi(4,3);

        }

    }

}
