using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //custom exception
    //person age must be >=18
    public class AgeException : Exception
    {
        public AgeException(string error) :base(error)
        {
            
        }
    }
    public class Person
    {
        private int age;
        public void acceptAge(int age)
        {
            if (age > 18)
            {
                this.age = age;
            }
            else
            {
                throw new AgeException("Your age is less than 18, not allowed");
            }
        }
    }

    public class Person2 
    {
        public void Accept(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name : "+name);
            }
            else
            {
                throw new NameException("Name is required");
            }
        }
    }
    public class NameException:Exception
    {
        
        public NameException(string error):base(error)
        {

        }
    }
}
