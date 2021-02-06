using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your first name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Please enter your patronic name:");
            string pname = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lname = Console.ReadLine();
            
            string fullName = GetFullName(fname, pname, lname);
            Console.WriteLine(fullName);
        }

        static string GetFullName(string firstName, string patronicName, string lastName)
        {
            string fullName = firstName + " " + patronicName + " " + lastName;
            return fullName; 
        }
    }

}
