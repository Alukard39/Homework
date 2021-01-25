using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter today minimal temperature in C!");
            string minT = Console.ReadLine();
            Console.WriteLine("Please enter today maximal temperature in C!");
            string maxT = Console.ReadLine();
            int avT = (Convert.ToInt32(maxT) + Convert.ToInt32(minT)) / 2;
            Console.WriteLine($"The avarage daily Temperature is {avT}");
        }
    }
}
