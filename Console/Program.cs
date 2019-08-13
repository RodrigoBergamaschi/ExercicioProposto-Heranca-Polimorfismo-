using System;
using Exercicio.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());
            
           
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Common, used or imported (c/u/i)?");
                char c = char.Parse(Console.ReadLine());
                Console.WriteLine("Product #" + i + " data:");
                if (c == 'c')
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Price:");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product prod = new Product(name, price);
                    list.Add(prod);
                }

                else if (c == 'u')
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Price:");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufecture date:");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    UsedProduct used = new UsedProduct(name, price, date);
                    list.Add(used);
                }
                else if (c == 'i')
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Price:");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs fee:");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ImportedProduct import = new ImportedProduct(name, price, fee);
                    list.Add(import);
                }

               
            }

            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.priceTag());
            }
        }
    }
}
