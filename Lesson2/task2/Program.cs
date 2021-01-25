using System;

namespace task2
{
    class Program
    {
        enum month
        {
            January = 1,
            Febrary = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            Jule = 7,
            August = 8,
            September = 9,
            Octover = 10,
            November = 11,
            December = 12

        }
        static void Main(string[] args)
        {
  
            Console.WriteLine("Please enter month number to get it name:");
            string snumber = Console.ReadLine();
            int inumber = Convert.ToInt32(snumber);
            Console.WriteLine("Name of the month is - {0}", Enum.GetName(typeof(month), inumber));

        }
    }
}
