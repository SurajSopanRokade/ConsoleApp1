using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Product3
    {
        String name;
        String description;
        double price;
        String category;
        

        public Product3(String name, String description, int price, String category)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.category = category;
        }

        static void Main(String[] args)
        {
           
            Product3[] products = new Product3[]{
            new Product3("Visual Studio", "Integrated development environment (IDE) from Microsoft", 499, ".NET Development"),
            new Product3("SQL Server", "Relational database management system from Microsoft", 999, "Database"),
            new Product3("Azure DevOps", "Cloud-based services for collaboration on software development projects", 0, "Development Tools"),
            new Product3("ASP.NET Core", "Cross-platform, high-performance, open-source framework for building modern, cloud-based, Internet-connected applications", 0, "Web Development"),
            new Product3("Entity Framework Core", "Object-relational mapping framework from Microsoft", 0, "Data Access")
        };

            
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product " + (i + 1) + ":");
                Console.WriteLine("Name: " + products[i].name);
                Console.WriteLine("Description: " + products[i].description);
                Console.WriteLine("Price: $" + products[i].price);
                Console.WriteLine("Category: " + products[i].category);
                Console.WriteLine("------------------------");
            }
        }
    }

   

}
