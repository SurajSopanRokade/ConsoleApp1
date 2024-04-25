using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student1
    {
        /* 1. 
           add method displayData inside Student class change
           values of id name in that method & also print the changed
           values in same method.Call displayData method from
           main method and see the output.Observe displayData can
           only be called by creating object of Student*/

        public int id { get; set; }
        public string name { get; set; }

        public void displayData()
        {
            Console.WriteLine($"id : {id}, Name : {name}");
        }

        static void Main(string[] args)
        {
            Student1 student1 = new Student1();
            student1.id = 1;
            student1.name = "suraj";
            student1.displayData();
        }

    }
}
