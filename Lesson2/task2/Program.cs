using System;

namespace Task2
{
    class Program
    {
        enum month
        {
            January =1,
            Febrary =2,
            March = 3,
            April= 4,
            May = 5,
            June = 6,
            Jule =7,
            August = 8,
            September = 9,
            October = 10,
            Novemvber = 11,
            December = 12
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of month to get its name:");
            int mnumber = Convert.ToInt32(Console.ReadLine());
            if (mnumber > 12)
            {
                Console.WriteLine("There is only 12 month");                
            }
            else if (mnumber < 1)
            {
                Console.WriteLine("There is no month less then 1");
            }
            else
            {
                string ret = Enum.GetName(typeof(month), mnumber);
                Console.WriteLine($"{mnumber} month name is {ret}");
            }
        }  
    }
}
