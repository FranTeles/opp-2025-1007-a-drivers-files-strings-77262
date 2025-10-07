using opp_2025_1007_files_string_77262.Models;
using opp_2025_1007_files_string_77262.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_2025_1007_files_string_77262.RunDemos
{
    public static class StringDriver
    {
        public static void Run()
        {
            Console.WriteLine("StringDriver.Run() called");
            FormattingDemo();
            FormtProducts();
        }

        public static void FormattingDemo()
        {
            string name = "Alice";
            string city = "Seattle";

            Console.WriteLine($"{name} : {city}");
            Console.WriteLine($"{name.PadLeft(10)}");
            Console.WriteLine($"{city.PadLeft(10)}");
            Console.WriteLine($"{name.PadLeft(30)}");
            Console.WriteLine($"{city.PadLeft(30)}");

            Console.WriteLine($"{name.PadLeft(10)} : {city.PadLeft(10)}");
        }

        public static void FormatProducts()
        {
            string product1 = "Laptop";
            decimal price1 = 999.99m;
            string product2 = "Smartphone";
            decimal price2 = 499.49m;

            Console.WriteLine($"{"Product",-15}{"Price",10}");
            Console.WriteLine($"{product1,-15}{price1,10}");
            Console.WriteLine($"{product2,-15}{price2,10}");
        }
    }
}
