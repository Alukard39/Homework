using System;
using System.Linq;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers with space delimiter:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int[] inumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
              inumbers[i] = Convert.ToInt32(numbers[i]);
            }
            int sum = inumbers.Sum();
            Console.WriteLine(sum);
        }

    }
}
