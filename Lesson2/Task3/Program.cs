using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number!");
            string snumber = Console.ReadLine();
            int inumber = Convert.ToInt32(snumber);
            if (inumber % 2 == 0)
            {
                Console.WriteLine("Your number is Even");
            }
            else {
                Console.WriteLine("Your number is Odd");
            }

        }
    }
}
