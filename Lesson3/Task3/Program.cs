using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word:");
            string input = Console.ReadLine();

            for (int i = input.Length; i != 0; i--)
            {
                char c = input[i-1];
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}