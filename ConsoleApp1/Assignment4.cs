using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Assignment4
    {
        /* 1. wc to create student class student contain id, name, three sub marks create first method to accept std details
            create second method to calculate percentage of three sub marks create third method to display all
            student details including percentage.*/

        private int sid, sub1, sub2, sub3;
        private string name;
        private double percentage;

        public void accept(int sid, int sub1, int sub2, int sub3, string name)
        {
            this.sid = sid;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
            this.name = name;
            this.percentage = calculatePerc();
        }
        public double calculatePerc()
        {
            return (sub1 + sub2 + sub3) / 3;
        }
        public string display()
        {
            return $"student id : {sid}, student name : {name}, percentage : {percentage}";
        }

        static void Main(string[] args)
        {
            Assignment4 assignment4 = new Assignment4();
            assignment4.accept(1, 78, 67, 89, "suraj");
            assignment4.calculatePerc();
            Console.WriteLine(assignment4.display());
        }

    }

    public class Product4
    {

        /*2. wc to create shopping class contain product id, pname, price, quantity create first method to accept
        product details, second to cal total bill, if the quantity is greater than zero otherwise show error msg*/

        private int pid;
        private string pname;
        private double price;
        private int quantity;
        private double bill;

        public void accept(int pid, string pname, double price, int quantity)
        {
            if (quantity != 0)
            {
                this.pid = pid;
                this.pname = pname;
                this.price = price;
                this.quantity = quantity;
                calbill();
            }  
        }

        public void calbill()
        {
            if (quantity != 0)
            {
                bill = quantity * price;
            }
            
        }
        
        public string display()
        {
            if (quantity != 0)
                return $"product id : {pid}, product name : {pname}, price : {price}, quantity : {quantity}, bill : {bill}";
            else
                return "Quantity is zero check again";
        }
        static void Main(string[] args)
        {
            Product4 product4 = new Product4();
            product4.accept(1, "pen", 10, 50);
            product4.calbill();
            Console.WriteLine(product4.display());
        }
    }
}
