using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StringBuilderDemo
    {
        static void Main(string[] args)
        {



            Console.WriteLine("----------StringBuilder class");

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            Console.WriteLine(sb);
            Console.WriteLine($"address of sb {sb.GetHashCode()}");

            Console.WriteLine("-----after changed the value");
            sb.Append("Hello to all");
            Console.WriteLine(sb);
            Console.WriteLine($"address of sb {sb.GetHashCode()}");


            sb.Clear();
            //sb.Length; // to get total characters . i.e. length of string


            StringBuilder sb1 = new StringBuilder("Hello, World!");

            // Displaying the current content of StringBuilder
            Console.WriteLine("Original StringBuilder: " + sb1);

            // Remove method
            sb1.Remove(7, 6); // Removes "World!"
            Console.WriteLine("StringBuilder after Remove(): " + sb1);

            // Replace method
            sb1.Replace("Hello", "Hi"); // Replaces "Hello" with "Hi"
            Console.WriteLine("StringBuilder after Replace(): " + sb1);

            // Clear method
            sb1.Clear(); // Clears the StringBuilder
            Console.WriteLine("StringBuilder after Clear(): " + sb1);

            // Capacity property
            Console.WriteLine("Capacity of StringBuilder: " + sb1.Capacity);

            // Length property
            Console.WriteLine("Length of StringBuilder: " + sb1.Length);
        }
    }

    public class StringDemo
    {
        private string str;

        public StringDemo(string str)
        {
            this.str = str;
        }

        // Method to check if the string is empty or null
        public bool IsEmptyOrNull()
        {
            return string.IsNullOrEmpty(str);
        }

        // Method to concatenate two strings
        public string Concat(string other)
        {
            return string.Concat(str, other);
        }

        // Method to get the character at a specific index
        public char CharAt(int index)
        {
            if (index < 0 || index >= str.Length)
                throw new IndexOutOfRangeException("Index out of range");

            return str[index];
        }

        // Method to convert string to char array
        public char[] ToCharArray()
        {
            return str.ToCharArray();
        }

        // Method to convert string to upper case
        public string ToUpper()
        {
            return str.ToUpper();
        }

        // Method to convert string to lower case
        public string ToLower()
        {
            return str.ToLower();
        }

        // Method to find the index of a specific character in the string
        public int IndexOf(char c)
        {
            return str.IndexOf(c);
        }

        // Method to find the last index of a specific character in the string
        public int LastIndexOf(char c)
        {
            return str.LastIndexOf(c);
        }

        // Method to get a substring from the string
        public string Substring(int startIndex, int length)
        {
            return str.Substring(startIndex, length);
        }

        // Method to check if a string contains another string
        public bool Contains(string substr)
        {
            return str.Contains(substr);
        }

        // Method to split the string based on a delimiter
        public string[] Split(char delimiter)
        {
            return str.Split(delimiter);
        }

        // Method to remove leading and trailing whitespace from the string
        public string Trim()
        {
            return str.Trim();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string testStr = "Hello, World!";
            StringDemo sm = new StringDemo(testStr);

            Console.WriteLine("Is string empty or null: " + sm.IsEmptyOrNull());
            Console.WriteLine("Concatenated string: " + sm.Concat(" Welcome!"));
            Console.WriteLine("Character at index 7: " + sm.CharAt(7));
            Console.WriteLine("String to char array: " + string.Join(",", sm.ToCharArray()));
            Console.WriteLine("String to upper case: " + sm.ToUpper());
            Console.WriteLine("String to lower case: " + sm.ToLower());
            Console.WriteLine("Index of 'o': " + sm.IndexOf('o'));
            Console.WriteLine("Last index of 'o': " + sm.LastIndexOf('o'));
            Console.WriteLine("Substring from index 7 to 12: " + sm.Substring(7, 5));
            Console.WriteLine("Contains 'World': " + sm.Contains("World"));
            Console.WriteLine("Split by ',': " + string.Join(",", sm.Split(',')));
            Console.WriteLine("Trimmed string: " + sm.Trim());
            Console.WriteLine($"address of str {testStr.GetHashCode()}");
        }
    }


}
