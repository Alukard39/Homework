using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            Console.WriteLine($"time was written to {filename}!");
            string time = DateTime.Now.ToString("HH:MM:ss");
            File.AppendAllLines(filename, new[] { time });
        }
    }
}
