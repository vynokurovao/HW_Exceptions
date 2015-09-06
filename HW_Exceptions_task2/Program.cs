using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions_task2
{
    class Program
    {
        private const uint PricesQuantity = 2;

        static void FillArrayFromShell(PriceDataStrorage prices)
        {
            for (int i = 0; i < PricesQuantity; i++)
            {
                bool ready = false;
                while (!ready)
                {
                    Console.WriteLine("Please, enter the product's name");
                    string productName = Console.ReadLine();

                    Console.WriteLine("Please, enter the name of the store");
                    string storeName = Console.ReadLine();

                    Console.WriteLine("Please, enter the cost");
                    string line = Console.ReadLine();

                    double cost;
                    try
                    {
                        cost = Convert.ToDouble(line);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine();
                        continue;
                    }

                    try
                    {
                        prices.AddPrice(new Price(productName, storeName, cost));
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    ready = true;
                }
            }

        }

        static void Main(string[] args)
        {
            PriceDataStrorage pricesDataStorage = new PriceDataStrorage();

            FillArrayFromShell(pricesDataStorage);

            Console.WriteLine("Please, enter the name of the store");
            try
            {
                List<Price> priceList = pricesDataStorage.FindAllProductsFromStore(Console.ReadLine());
                foreach (Price price in priceList)
                {
                    Console.WriteLine(String.Format("Product's name is {0}", price.ProductName));
                    Console.WriteLine(String.Format("Product's cost is {0}", price.Cost));
                }
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
