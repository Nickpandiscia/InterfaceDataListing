using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDataListing
{
    public class ListDataAccess : IDataAccess
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
            Console.WriteLine($"I am reading this from List Data Access.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am Saving data from a List Data Access Database.");
        }

    }
}
