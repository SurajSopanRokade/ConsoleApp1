using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        private int code;
        private string name;
        private double price;


        // create property

        public int Code
        {
            set { code = value; }
            get { return code; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
    }

    public class Product2
    {
        //auto implemented property

        // prop tab twice
        // it will create datamember internally and assign the value and also retrive

        public int Code { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }


    }
}
