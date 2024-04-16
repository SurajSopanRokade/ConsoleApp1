using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Assignment3
    {
        private int empid; //4 bytes
        private string empname; //4 bytes
        private double bs;
        private double hra, pf, gross; //32 bytes
       

       public void Assign()
        {
            empid = 1;
            empname = "Nitin";
            bs = 4000;
            hra = 2000;
            pf = 1000;
        }

        public void Accept(int id, string name, double b, double h, double p)
        {
            empid = id;
            empname = name;
            bs = b;
            hra = h;
            pf = p;

        }
        public void CalculateSalary()
        {
            gross = (bs + hra) - pf;
        }
        public string Display()
        {
            return $"empid = {empid}, empname = {empname}, gross = {gross}";
        }

        static void Main(string[] args)
        {
            Assignment3 c = new Assignment3();
            c.Assign();
            c.Accept(2, "suraj", 45000, 4500, 3455);
            c.CalculateSalary();
            Console.WriteLine(c.Display());
        }
    }

    public class Student
    {
        private int rollno;
        private string name;
        private DateDemo d;

        public Student()
        {
            rollno = 1;
            name = "Suraj";
            d = new DateDemo();
        }
        //constructor with parameter
        public Student(int r, string nm, DateDemo dd)
        {
            rollno = r;
            name = nm;
            d = dd;
        }
        public string Display()
        {
            return $"Roll no = {rollno}, name = {name} date = {d}";
        }

        static void Main(string[] args)
        {
            Student c = new Student(); // no parameter
            Student s1 = new Student(2, "Akshay", new DateDemo(2,3,2023)); // parametric constructor call
            String s =s1.Display();
            Console.WriteLine(s);
        }

        public class DateDemo
        {
            int dd;
            int mm;
            int yy;

            public DateDemo()
            {
                dd = 1; 
                mm = 2;
                yy = 2023;
            }

            public DateDemo(int dd, int mm, int yy)
            {
                this.dd = dd;
                this.mm = mm;
                this.yy = yy;
            }
            public String DisplayAttribute()
            {
                return $"{dd}/{mm}/{yy}";
            }

            static void Main(string[] args)
            {
                DateDemo d1 = new DateDemo();
                String s =d1.DisplayAttribute();
                Console.WriteLine(s);
            }

        }
    }

    
}

// auto implemented properties

