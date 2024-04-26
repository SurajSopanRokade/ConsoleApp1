using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee2
    {
        /* 1.	Create class Employee. Add fields like id, name, basic salary, HRA, TA, PF.Accept the value of id, name & basic salary from constructor.
         * Calculate the employee gross salary  & display employee details using ToString() method
                     a.HRA- 40% of basic salary
                     b.TA – 20% of basic salary
                     c.	PF -12 % of basic salary*/
        private int id;
        private string name;
        private double salary, HRA, TA, PF, gross;

        public Employee2()
        {

        }
        public Employee2(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            HRA = 0.4 * salary;
            TA = 0.2 * salary;
            PF = 0.12 * salary;
        }

        public void calculategross()
        {
            gross = salary + HRA + TA - PF;
        }

        public override string ToString()
        {
            return $"Employee id : {id}, name : {name}, grosssalary : {gross}";
        }

        static void Main(string[] args)
        {
            Employee2 e = new Employee2(1, "Suraj ", 100000);
            e.calculategross();
        }
    }

    public class Product6
    {
        //2.	Create class Product. Add fields like id, name and price.
        //Create properties for each field. Use object initializer syntax initialize the object.
        //Print product details using ToString()

        //3.	Use above Product class, create Discount method & accept the discount percentage.
        //Give discount to the price & Display actual price & discounted price
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int discount { get; set; }

        public void discountprice()
        {
            price = price - ((price * discount) / 100);
        }
        public override string ToString()
        {
            return $"Product_id : {id}, Product_Name : {name}, Product_price : {price}";
        }

        static void Main(string[] args)
        {
            Product6 p = new Product6() { id = 1, name = "Pen", price = 10, discount = 2 };
            p.discountprice();
            Console.WriteLine(p);
        }

    }

    public class Student4
    {
        //4.	Create class Student, with roll no , name , percentage auto implemented properties.
        //Use property initialize syntax to assign the values. Print the student details

        public int rollno { get; set; }
        public string name { get; set; }
        public double percentage { get; set; }

        public override string ToString()
        {
            return $"Student roll : {rollno}, Name : {name}, Percentage : {percentage}";
        }
        static void Main(string[] args)
        {
            Student4 p = new Student4() { rollno = 1, name = "suraj", percentage = 96 };
            Console.WriteLine(p);
        }
    }

    public class Employee23
    {
        public static int empid = 0;
        public int id;
        public string ename;
        public double salary;
        public static int objcount = 0;

        public Employee23(string ename, double salary)
        {
            this.id = changeId();
            this.ename = ename;
            this.salary = salary;
            objcount = objCount();
        }

        public static int objCount()
        {
            return objcount = objcount + 1;
        }

        public static int changeId()
        {
            return empid = empid + 1;
        }

        public override string ToString()
        {
            return $"EmployeeId : {id}, EmployeeName : {ename}, Salary : {salary}, TotalObject : {objcount}";
        }

        static void Main(string[] args)
        {
            Employee23 e = new Employee23("Suraj", 34000);
            Employee23 e1 = new Employee23("Sudarshan", 44000);
            Employee23 e2 = new Employee23("Aadersh", 54000);
            Employee23 e3 = new Employee23("Yogesh", 74000);
            Console.WriteLine(e);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);

            Employee23.changeId();
        }
    }
}
