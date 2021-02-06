using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] address = new string[5, 2]
            {
                {"Dmitry", "Dmitry@mail.ru"},
                {"Ivan", "905-905-9595"},
                {"Lena", "909-909-9999" },
                {"Igor", "Igor@gmail.com" },
                {"Ira", "Ira@mail.ru" }
            };
            Console.WriteLine("There is a list of your contacts:");
            int n = 0;
                while (n < address.GetLength(0))
                {
                    Console.Write($"{address[n, 0]}\n");
                    n++;
                }
                Console.WriteLine();
            Console.WriteLine("Please enter the Name to get contact information:");
            string input = Console.ReadLine();
            bool isFound = false;
            {
                for (int i = 0; i < address.GetLength(0); i++)
                {
                    if (address[i, 0] == input)
                    {
                        Console.WriteLine($"Contact information for {address[i, 0]} is {address[i, 1]} ");
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    Console.WriteLine("Contact didn't founded");
                }
            }
        }
    }
}
