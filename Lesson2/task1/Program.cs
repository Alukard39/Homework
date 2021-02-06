using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter today minimal temperature in C:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter today maximal temperature in C:");
            int max = Convert.ToInt32(Console.ReadLine());

            int median = (min + max) / 2;
            Console.WriteLine($"Median today temperature is {median}");
        }
    }
}
