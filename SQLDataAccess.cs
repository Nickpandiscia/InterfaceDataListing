using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDataListing
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ Name = "Xbox", Price = 400},
             new Product(){ Name = "Toaster", Price = 75},
              new Product(){ Name = "Laptop", Price = 879},
               new Product(){ Name = "Post-it Notes", Price = 2},

        };
        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine($"I am reading this from SQL Data Access.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am Saving data from a SQL Data Access Database.");
        }

    }
}
