using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SumPrime
    {
        //2. wc to find out the sum of prime number from the array
        public void sum(int[] arr)
        {

            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                int count = 0;
                for (int j = 2; j < arr[i]/2; j++)
                {
                    if (arr[i] / j == 0)
                    {
                        count++;
                    }
                }
                if(count==0)
                {
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            SumPrime s = new SumPrime();
            int[] arr = new int[4] { 3, 5, 7, 17 };
            s.sum(arr);
        }
    }

    public class Search
    {
        public int check(int[] arr, int num)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
                Search s = new Search();
            int[] arr = new int[4] { 2, 3, 4, 5 };
            int t = 1;
            int c=s.check(arr, t);
            if(c!=-1)
            {
                Console.WriteLine($"{t} is present at index {c}");
            }
            else
            {
                Console.WriteLine("Number is not present in given array");
            }
        }
    }
}
