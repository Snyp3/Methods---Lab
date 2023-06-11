using System.Diagnostics;

namespace P05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine($"{QuantityOfProduct(product,quantity):f2}");

        }

        private static double QuantityOfProduct(string product,int quantity )
        {
            double price = 0;
            
            switch (product)
            {
                case "coffee":
                  price = quantity * 1.50;
                    break;
                case "water":
                    price = quantity * 1.00;
                    break;
                case "coke":
                    price = quantity * 1.4;
                    break;
                case "snacks":
                    price = quantity * 2.00;
                    break;
            }

            return price;
        }
    }
}