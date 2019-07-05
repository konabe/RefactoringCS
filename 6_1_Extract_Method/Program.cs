using System;

namespace _6_1_Extract_Method
{
    class Program
    {
        private readonly string _name = "Linus";

        static void Main()
        {
            var p = new Program();
            p.PrintOwing(2.98);
        }

        private void PrintOwing(double amount)
        {
            PrintBanner();

            Console.WriteLine($"name: {_name}");
            Console.WriteLine($"amount: {amount}");
        }

        private void PrintBanner()
        {
            Console.WriteLine("Banner");
        }

    }
}
