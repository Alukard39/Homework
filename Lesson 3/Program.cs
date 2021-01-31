using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5]
            {
                {01, 02, 03, 04, 05 },
                {11, 12, 13, 14, 15 },
                {21, 22, 23, 24, 25 },
                {31, 32, 33, 34, 35 },
                {41, 42, 43, 44, 45 }
            };
            for(int j = 0, i = 0;i < 5;i++, j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
         
    }
