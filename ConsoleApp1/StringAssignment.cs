using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SplitString
    {
        //1.	WAP to split string into 2 tokens where string is “HELLO$WORLD”
        public void check(string str)
        {
            string[] str1 = str.Split('$');
            foreach (string str2 in str1)
            {
                Console.WriteLine(str2);
            }
        }
        static void Main(string[] args)
        {
            SplitString s = new SplitString();
            s.check("HELLO$WORLD");
        }
    }

    public class FindFirstOcc
    {
        //2.	Write a C# program to find first occurrence of a character in a given string.
        public int check(string str, char c)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            FindFirstOcc s = new FindFirstOcc();
            int a=s.check("Suraj", 'a');
            Console.WriteLine($"first occurance of char is at index {a}");
        }
    }

    public class CountOccOfChar
    {
        //3.	Write a C# program to count occurrences of a character in given string.
        public void check(string str, char c)
        {
            int count = 0;
            for(int i = 0;i < str.Length;i++)
            {
                if (str[i] == c)
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of Occurance of char in given string is {count}");
        }
        static void Main(string[] args)
        {
            CountOccOfChar s = new CountOccOfChar();
            s.check("Suuuuraj", 'u');
        }
    }

    public class TremLead
    {
        //4.	Write a C# program to trim leading white space characters in a string.
        public void Trim1(string str)
        {
            /*string str1 = str.TrimStart();
            Console.WriteLine(str1);*/
            string str1="";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    str1 = str1 + str[i];
                }
            }
            Console.WriteLine(str1);
        }
        static void Main(string[] args)
        {
            TremLead s = new TremLead();
            s.Trim1("   Suraj");
        }
    }

    public class CountWords
    {
        //5.	Write a C# program to count total number of words in a string. 
        public void CountTotal(string str)
        {
            string[] str1 = str.Split(' ');
            int count = 0;
            for(int i = 0; i<str1.Length; i++)
            {
                if (str1[i] != "")
                {
                    count++;
                }
            }
            Console.WriteLine($" No of words in string {count}");
        }
        static void Main(string[] args)
        {
            CountWords s = new CountWords();
            s.CountTotal("Hello   I Love .Net and C#");
        }
    }

    public class RemoveAllOcc
    {
        //6.	Write a C# program to remove all occurrences of a character from string.
        public void check(string str, char c)
        {
            
            char[] ch  = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (ch[i] == c)
                {
                    ch[i] = '$';
                }
            }
            
            string str2 = "";
            for(int i=0; i<str.Length; i++)
            {
                if (ch[i] != '$')
                {
                    str2 = str2+ ch[i];
                }
            }
            Console.WriteLine($"String after delete all occurance of char : {str2}");
        }
        static void Main(string[] args)
        {
            RemoveAllOcc s = new RemoveAllOcc();
            s.check("Hii My Name is Suraj", 'S');
        }
    }

    public class TrimeTrail
    {
        //7.	Write a C# program to trim trailing white space characters in a string.
        public void check(string str)
        {
            /*string str1 = str.TrimEnd();
            Console.WriteLine(str1);*/
            //or
            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    str1 = str1 + str[i];
                }
            }
            Console.WriteLine(str1);
        }
        static void Main(string[] args)
        {
            TrimeTrail s = new TrimeTrail();
            s.check("Suraj   ");
        }
    }

    public class ToggleCase
    {
        //8.	Write a C# program to toggle case of each character of a string.

        public void check(string str)
        {
            char[] ch = str.ToCharArray();
            for(int i=0; i<ch.Length; i++)
            {
                if (char.IsUpper(ch[i]))
                {
                    ch[i] = char.ToLower(ch[i]);
                }
                else if (char.IsLower(ch[i]))
                {
                    ch[i] = char.ToUpper(ch[i]);
                }
            }
            string str2 = "";
            for(int i = 0; i < ch.Length; i++)
            {
                str2 = str2+ ch[i];
            }
            Console.WriteLine(str2);
        }
        static void Main(string[] args)
        {
            ToggleCase toggle = new ToggleCase();
            toggle.check("Hii My Name is SURAJ");
        }
    }

    public class CountVowels
    {
        public void check(string str)
        {
            //9.	Write a C# program to count total number of vowels and consonants in a string.
            char[] ch = str.ToCharArray();
            int v = 0;
            int c = 0;
            for(int i=0; i<ch.Length ; i++)
            {
                if (ch[i] == 'a' || ch[i]=='e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u' || ch[i] == 'A' || ch[i] == 'E' || ch[i] == 'I' || ch[i] == 'O' || ch[i] == 'U') 
                {
                    v++;
                }
                else
                {
                    c++;
                }
            }
            Console.WriteLine($" voewls : {v} , Consolents : {c}");


        }
        static void Main(string[] args)
        {
            CountVowels count = new CountVowels();
            count.check("Suraj");
        }
    }

    public class ReverseString
    {
        //10.	Write a C# program to find reverse of a string.
        public void find(string str)
        {
            char[] ch = str.ToCharArray();
            string str2 = "";
            for(int i= ch.Length-1; i>=0 ;i--)
            {
                str2 = str2 + ch[i];
            }
            Console.WriteLine(str2);
        }
        
        static void Main(string[] args)
        {
            ReverseString count = new ReverseString();
            count.find("Suraj");
        }
    }

    public class ReverseWords
    {
        //11.	Write a C# program to reverse order of words in a given string.
        public void check(string str)
        {
            string[] str2 = str.Split(" ");
            string str3 = "";
            int a = str2.Length-1;
            for(int i=0;  i<str2.Length; i++)
            {
                str3 = str3 + str2[a] + " ";
                a--;
            }
            Console.WriteLine(str3);
        }
        static void Main(string[] args)
        {
            ReverseWords count = new ReverseWords();
            count.check("Hii I Love Java");
        }
    }

    public class FindHighF
    {
        //12.	Write a C# program to find highest frequency character in a string.
        public void find(string str)
        {
            int max = 0;
            char c = ' ';
            char[] ch = str.ToCharArray();
            for(int i=0; i<ch.Length-1 ; i++)
            {
                int count = 0;
                for(int j=0; j<ch.Length; j++)
                {
                    if (ch[i] == ch[j] && i > j)
                    {
                        break;
                    }
                    else if (ch[i] == ch[j])
                    {
                        count++;
                    }
                }
                if(count!=0)
                {
                    if (max < count)
                    {
                        max = count;
                        c = ch[i];
                    }
                }
            }
            Console.WriteLine($"Max freq char {c} and freq is {max}");
        }
        static void Main(string[] args)
        {
            FindHighF f  = new FindHighF();
            f.find("Surajjjjjjj");
        }
    }

    public class Separate
    {
        //13.	Write a C# program to find total number of alphabets, digits or special character in a string.
        public void find( string str)
        {
            int num = 0;
            char[] c = str.ToCharArray();
            int alpha = 0;
            int special = 0;
            for(int i=0; i<c.Length; i++)
            {
                if ((c[i] >= 'A' && c[i]<='Z') || (c[i]>='a' && c[i]<='z') )
                {
                    alpha++;
                }
                else if (c[i] >='1' && c[i] <= '9')
                {
                    num++;
                }
                else
                {
                    special++;
                }
            }
            Console.WriteLine($"Alphabets : {alpha}, Numbers : {num}, Special : {special}");
        }
        static void Main(string[] args)
        {
            Separate se = new Separate();
            se.find("surajAshduf234cj7vnu8$$k&");
        }
    }

    public class DuplicateWords
    {
        //15.	Write a C# program to find the duplicate words and their number of occurrences in a string
        public void find( string str )
        {
            string[] str1 = str.Split(" ");
            for(int i=0;i<str1.Length ; i++)
            {
                int count = 0;
                for(int j=0;j<str1.Length ; j++)
                {
                    if (str1[i] == str1[j] && i > j)
                    {
                        break;
                    }
                    else if (str1[i] == str1[j] )
                    {
                        count++;
                    }
                }
                if(count != 0)
                {
                    Console.WriteLine($"String : {str1[i]}, Freq : {count}");
                }
            }
        }
        static void Main(string[] args)
        {
            DuplicateWords d  = new DuplicateWords();
            d.find("Hello Hello I Love Java I Love .Net Too");
        }
    }

    public class Anagram
    {
        public void check(string str1, string str2)
        {
            //16.	Write a C# program to check whether two strings are anagram or not?
            char[] c1 = str1.ToCharArray();
            char[] c2 = str2.ToCharArray();
            int count = 0;
            if(c1.Length == c2.Length)
            {
                for (int i = 0; i < c1.Length; i++)
                {
                    for (int j = 0; j < c2.Length; j++)
                    {
                        if (c1[i] == c2[j])
                        {
                            count++;
                            break;
                        }
                    }
                }
                if (count == c1.Length)
                {
                    Console.WriteLine("Strings are Anagram");
                }
                else
                {
                    Console.WriteLine("Not Anagram");
                }
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
            
        }
        static void Main(string[] args)
        {
            Anagram d = new Anagram();
            d.check("listen", "silent");
        }
    }

    public class ReverseString2
    {
        //17.	Write a C# program to reverse a given string with preserving the position of spaces
        public void check(string str)
        {
            ArrayList list = new ArrayList();
            ArrayList list2 = new ArrayList();
            ArrayList list3 = new ArrayList();
            char[] c = str.ToCharArray();
            for(int i=0; i<c.Length; i++)
            {
                if (c[i] == ' ')
                {
                    list.Add(i);
                }
                else if (c[i]!=' ')
                {
                    list2.Add(c[i]);
                }
            }
            
            for(int i=list2.Count-1; i>=0; i--)
            {
                list3.Add(list2[i]);
                
            }
           

            for(int i=0; i<list.Count; i++)
            {
                int index = (int)list[i]; 
                
                    list3.Insert(index, " "); 
                
            }
            string str2="";
            for(int i=0; i<list3.Count; i++)
            {
                str2 = str2 + list3[i];
            }
            Console.WriteLine(str2);
        }
        static void Main(string[] args)
        {
            ReverseString2 r = new ReverseString2();

            r.check("Hii I Love java");
        }
    }

    public class FindLongest
    {
        //18.	WAP to find longest word in the given sentence
        public void find(string str)
        {
            int max = 0;
            string str1 = "";
            string[] s = str.Split(' ');
            for(int i=0; i<s.Length;i++)
            {
                if (s[i].Length > max)
                {
                    max = s[i].Length;
                }
            }
            for(int i=0; i<s.Length;i++)
            {
                if (s[i].Length == max)
                {
                    Console.WriteLine($"Longest String {s[i]} and length is {s.Length}");
                }
            }
            
        }
        static void Main(string[] args)
        {
            FindLongest r = new FindLongest();
            r.find("Hello i am suraj");
        }
    }

    public class Swap
    {
        //19.	How do you swap two string variables without using third or temp variable in C#
        public void check(string a, string b)
        {

            
            Console.WriteLine($"Before swap: a = {a}, b = {b}");

            
            a = a + b;
            b = a.Substring(0, a.Length - b.Length);
            a = a.Substring(b.Length);

            Console.WriteLine($"After swap: a = {a}, b = {b}");
        }
        static void Main(string[] args)
        {
            Swap r = new Swap();
            r.check("Hello", "Suraj");
        }
    }

    public class EmailCheck
    {
        //20.	Accept email_id from user and check valid or not(should contain @,.)
        public bool check(string email)
        {
            bool isValid = false;
            
            if (email.Contains('@') && email.Contains('.'))
            {
                
                if (email.IndexOf('@') > 0 && email.LastIndexOf('@') < email.Length - 1)
                {
                    
                    if (email.IndexOf('.') > email.IndexOf('@') + 1 && email.LastIndexOf('.') < email.Length - 1)
                    {
                        isValid = true;
                    }
                }
            }
            return isValid;
        }
        static void Main(string[] args)
        {
            EmailCheck r = new EmailCheck();
            bool a = r.check("suraj@gmail.com");
            if(a)
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }
        }
    }
    
    public class Change
    {
        //21.	Accept sentence replace each vowel by next consecutive character
        public void check(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] result = str.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                char c = result[i];
                if (Array.IndexOf(vowels, c) != -1)
                {
                    result[i] = (char)(c + 1);
                    if (result[i] > 'z') 
                        result[i] = 'a';
                    else if (result[i] > 'Z' && result[i] < 'a') 
                        result[i] = 'A';
                }
            }

            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Change c = new Change();
            c.check("Suraj");
        }
    }

    public class SortArrayString 
    {
        //22.	Create an array of 10 names sort in descending order
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("suraj");
            list.Add("yogesh");
            list.Add("sudarshan");
            list.Add("aadersh");
            list.Add("amit");
            list.Add("amol");
            list.Add("rakesh");
            list.Add("sumit");

            list.Sort();

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            
        }
    }

    public

    
}
