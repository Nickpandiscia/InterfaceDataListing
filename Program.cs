using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace InterfaceDataListing
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;
            bool correctInput;
            do
            {
                Console.Clear();
                correctInput = true;
                Console.WriteLine("What database would you like to use: mongo, sql, or list?");
                userAnswer = Console.ReadLine();

                if(userAnswer != "sql" && userAnswer != "mongo" && userAnswer != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Sorry. Invalid input.");
                    Thread.Sleep(1000);
                }

            } while (!correctInput);
            Console.Clear();


            IDataAccess db = DataAccessFactory.GetDataAccessType(userAnswer);

            var products = db.LoadData();
            db.SaveData();

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
