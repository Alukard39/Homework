using System;
using System.IO;

namespace Task1
{
        class Program
    {
        static void Main()
        {
            string filename = "console.txt";
            Console.WriteLine("Please enter any data:");
            string input = Console.ReadLine();
            File.WriteAllText(filename,input);
        }

    }
}
