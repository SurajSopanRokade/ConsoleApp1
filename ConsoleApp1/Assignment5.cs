using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{


    public class Employee
    {
        protected int empid; //4 bytes
        protected string empname; //4 bytes
        protected double bs;
        protected double hra, pf, gross; //32 bytes


        public Employee()
        {
            empid = 1;
            empname = "Nitin";
            bs = 4000;
            hra = 2000;
            pf = 1000;
        }

        public Employee(int id, string name, double b, double h, double p)
        {
            empid = id;
            empname = name;
            bs = b;
            hra = h;
            pf = p;

        }
        public virtual void CalculateSalary()
        {
            gross = (bs + hra) - pf;
        }
        public virtual string Display()
        {
            return $"empid = {empid}, empname = {empname}, Employee gross = {gross}";
        }

        static void Main(string[] args)
        {
            Employee c = new Employee ( 2, "suraj", 45000, 4500, 3455 );
            Console.WriteLine(c.Display());
        }
    }
    // Manager  as child class or derived class
    //extend we use :
    // to access base class memebers we will use base keyword, in java it is super()
    public class Manager : Employee
    {
        // base keyword will cass the base class constructor
        private double food;
      public Manager() : base()
        {

        }
      public Manager(int id, string name, double b, double h, double p, double food) : base(id, name, b, h, p)
        {
            this.food = food;
        }
        // when you will create object of child class, first base class const get call then child class const get call
        //base keyword is used to access the base class datamembers (const, method, protected variables)

        //calculate salary for manager

        public override void CalculateSalary()
        {
            gross = (bs + hra + food) - pf;
        }
        //polymorphism multiple object same behaviour but implementation different
        //Employee __> calculate salary
        //Manager __> calculate salary
        //both have same behaviour but implementation different + food in manager
        //this concept is polymorphism we use method overriding concept
        //method overriding : when base class and child class have same method signature (return type and no of parameter list)
        //but implementation is differenct that is call as method overriding to achive we use 2 keywords 
        // 1 virtual and 2. override
        // virtual we will apply to base class method and override keyword we use to child class method
        // in java we only use @Override in child class method

        public override string Display()
        {
            return $"empid = {empid}, empname = {empname}, Manager gross = {gross}";
        }
    }
}
