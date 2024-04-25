using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayAssignment
    {
        //1.	WAP to search for a given number in an array and accordingly print the index if exists

        public int search(int a, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            ArrayAssignment a = new ArrayAssignment();
            int[] arr1 = new int[4] { 1, 23, 4, 5 };
            int c = 4;
            int s= a.search(c, arr1);
            if(s>0)
            {
                Console.WriteLine($"{c} is present at index {s}");
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
    }

    public class OverloadingAssign1
    {
        //2.	Write two methods that return the average of an array with following headers.
       /* i.  public static int average(int[] array)
          ii. public static double average(double[] array).
          iii.Write main and invoke the 2 methods.*/

        public int average(int[] arr)
        {
            Console.WriteLine("In Int method");
            int sum = 0;
            foreach (int item in arr)
            {
                sum = sum + item;
            }
            return sum/arr.Length;
        }
        public double average(double[] arr)
        {
            Console.WriteLine("In double method");
            double sum = 0;
            foreach (int item in arr)
            {
                sum = sum + item;
            }
            return sum/arr.Length;
        }
        static void Main(string[] args)
        {
            OverloadingAssign1 a = new OverloadingAssign1();
            int[] arr = new int[4] { 1, 3, 4, 5 };
            int c= a.average(arr);
            Console.WriteLine(c);
            double[] arr1 = new double[4] { 1, 3, 4, 5 };
            double c1=Convert.ToDouble(a.average(arr1 ));
            Console.WriteLine(c1);

        }
    }
    public class FindNegative
    {
        //3.	WAP to print all negative elements in an array and also count total number of negative elements in an array.
        public void Check(int[] arr)
        {
            int count = 0;
            foreach (int item in arr)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                    count++;
                }
            }
            Console.WriteLine("Count : "+count);
        }
        static void Main(string[] args)
        {
            FindNegative f1 = new FindNegative();
            int[] arr = new int[4] { 1, 2, 3, -4 };
            f1.Check(arr);
        }
    }
    public class ArraySplit
    {
        //4.	WAP to put even and odd elements of array in two separate arrays
        public void check(int[] arr)
        {
            int even = 0;
            int odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else if (arr[i] %2!=0)
                {
                    odd++;
                }
            }
            int[] Even = new int[even];
            int[] Odd = new int[odd];
            int e = 0;
            int o = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Even[e] = arr[i];
                    e++;
                }
                else if (arr[i] % 2 != 0)
                {
                    Odd[o] = arr[i];
                    o++;
                }
            }
            foreach (int i in Even)
            {
                Console.WriteLine("Even : "+i);
            }
            Console.WriteLine("_________________________");
            foreach (int i in Odd)
            {
                Console.WriteLine("Odd : " + i);
            }
        }
        static void Main(string[] args)
        {
            ArraySplit a1 = new ArraySplit();
            int[] arr = new int[] {2,3,4,5,6,7,8,9};
            a1.check(arr);
        }
    }

    public class MaxMin
    {
        public void cal(int[] arr)
        {
            //5.	WAP to find the maximum and minimum value in an array.
            int max = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                if (arr[i] > max)
                {
                    max= arr[i];
                }
            }
            int min = max;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min= arr[i];
                }
            }
            Console.WriteLine("Max : "+max);
            Console.WriteLine("Min : "+min);
        }
        static void Main(string[] args)
        {
            MaxMin m = new MaxMin();
            int[] arr= new int[] {2,3,4,5,7,8,9};
            m.cal(arr);
        }
    }

    public class DuplicateEle
    {
        //6.	WAP to find and count total number of duplicate elements in an array.
        public void find(int[] arr)
        {
            for(int i = 0; i<arr.Length ; i++)
            {
                int count = 0;
                for(int j=0; j<arr.Length ; j++)
                {
                    if (arr[i] == arr[j] && i > j)
                    {
                        break;
                    }
                    else if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if(count !=0)
                {
                    Console.WriteLine($"number {arr[i]} freq is {count}");
                }
            }
           
        }
        static void Main(string[] args)
        {
            DuplicateEle e = new DuplicateEle();
            int[] arr = new int[] { 2, 3, 4, 4, 4, 5, 5, 2, 2, 2, 2, 2 };
            e.find(arr);
        }
    }

    public class Unique
    {
        public void find(int[] arr)
        {
            //7.	WAP to print all unique elements in the array.
            for (int i = 0;i<arr.Length ; i++)
            {
                int c = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        c++;
                    }
                }
                if (c == 1)
                {
                    Console.WriteLine($"Unique element {arr[i]}");
                }
            }
        }
        static void Main(string[] args)
        {
            Unique u  = new Unique();
            int[] arr = new int[] { 2, 3, 4, 4, 5, 5, 2, 2, 7 };
            u.find(arr);
        }
    }

    public class FindSecondSmallest
    {
        //8.	WAP to find the second smallest element in an array.
        public void find(int[] arr)
        {
            int max = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max= arr[i];
                }
            }
            int min = max;
            for(int i=0; i<arr.Length; i++)
            {
                if( min > arr[i])
                {
                    min = arr[i];
                }
            }
            int min1 = max;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != min)
                {
                    if (min1 > arr[i])
                    {
                        min1 = arr[i];
                    }
                }
                
            }
            Console.WriteLine("Second smallest "+min1);

        }
        static void Main(string[] args)
        {
            FindSecondSmallest u = new FindSecondSmallest();
            int[] arr = new int[] { 1,2, 3, 4, 4, 5, 5, 2 };
            u.find(arr);
        }
    }
    public class DuplicateEle2
    {
       // 9.	WAP to count frequency of each element in an array.
        public void find(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && i > j)
                    {
                        break;
                    }
                    else if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count != 0)
                {
                    Console.WriteLine($"number {arr[i]} freq is {count}");
                }
            }

        }
        static void Main(string[] args)
        {
            DuplicateEle e = new DuplicateEle();
            int[] arr = new int[] { 2, 3, 4, 4, 4, 5, 5, 2, 2, 2, 2, 2 };
            e.find(arr);
        }
    }
    public class MergeTwo
    {
        //10.	WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.
        public void merge(int[] arr1, int[] arr2)
        {
            int[] arr = new int[arr1.Length + arr2.Length];
            int t = 0;
            int m = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if (i < arr1.Length)
                {
                    arr[i] = arr1[t++];
                }
                else
                {
                    arr[i] = arr2[m++];
                }
                
            }
            

            for(int i=0; i<arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arr[i] = '$';
                    }
                }
            }
            
            int count = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == '$')
                {
                    count++;
                }
            }
            int[] arr4 = new int[arr.Length-count];
            int k = 0;
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] != '$')
                {
                    arr4[k] = arr[i];
                    k++;
                }
            }
            foreach (int item in arr4)
            {
                Console.WriteLine("Final Array : "+item);
            }
        }
        
        static void Main(string[] args)
        {
            MergeTwo m = new MergeTwo();
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = new int[] { 1,2,3,4 };
            m.merge(arr1, arr2);
        }
    }

    public class SortArray
    {
        //11.	WAP sort array elements in ascending order.
        public void check(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                int temp = 0;
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            SortArray s = new SortArray();
            int[] arr = new int[] { 2, 4, 3, 2, 6, 7, 4, 3 };
            s.check(arr);
        }
    }

    public class ReverseArray
    {
        //12.	WAP to reverse the array itself, don’t print array in reverse – I want current array reverse. Means
        //e.g. arr[] = [3, 90, 45, 29, 37, 78] so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array.
        public void cal(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;                  
                }
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            ReverseArray s = new ReverseArray();
            int[] arr = new int[] { 2, 3, 4, 5, 6, 6, 4, 8, 9 };
            s.cal(arr);
        }
    }
    public class EqualArray
    {
        //13.	Write a  program to test the equality of two arrays. Means e.g arr1[] = [12, 22, 32, 42, 52, 62] and
        //arr2[] = [52, 22, 62, 12, 42, 22] Here both arrays are equal.
        public void check(int[] arr1, int[] arr2)
        {
            int count = 0;
            if(arr1.Length == arr2.Length)
            {
                for(int i=0; i<arr1.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            count++;
                            break;
                        }
                    }
                }
               // Console.WriteLine("Count : "+count);
                if (count == arr1.Length)
                {
                    Console.WriteLine(count);
                    Console.WriteLine("Two arrays are equal");
                }
                else
                {
                    Console.WriteLine("Not equal");
                }
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
        static void Main(string[] args)
        {
            EqualArray s = new EqualArray();
            int[] arr1 = new int[] { 12, 22, 32, 42, 52, 62 };
            int[] arr2 = new int[] { 52, 22, 62, 12, 42, 32 };
            s.check(arr1, arr2);
        }
    }

    public class ReplacePro
    {
        //14.	WAP to replace all negative value with its immediate left elements square.
        //Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9] Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].
        public void replace(int[] arr1) 
        { 
            for(int i=0; i<arr1.Length ; i++)
            {
                if (i!=0 && arr1[i] < 0)
                {
                    arr1[i] = (arr1[i-1]* arr1[i-1]);
                }
            }
            foreach (int item in arr1)
            {
                Console.WriteLine($"array elements{item}");
            }

        }
        static void Main(string[] args)
        {
            ReplacePro s = new ReplacePro();
            int[] arr = new int[] { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            s.replace(arr);
        }
    }

    public class ProgramSortNeg
    {
        public void check(int[] arr)
        {
            //15.	WAP to arrange the elements of an given array of integers where all negative integers appear before all the positive integers.
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, -5, -6, -7, -8 };
            ProgramSortNeg s = new ProgramSortNeg();
            s.check(arr);
        }
    }
}
