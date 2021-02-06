using System;

namespace Task6
{
    class Program
    {
        [Flags]
        public enum DaysOfWork {
            Monday = 0b0000001,
            Tuesday = 0b0000010,
            Wednesday = 0b0000100,
            Thursday = 0b0001000,
            Friday = 0b0010000,
            Saturday = 0b0100000,
            Sunday = 0b1000000
        }
        static void Main(string[] args)
        {
            //DateTime dt = DateTime.Now;
            //string d = dt.DayOfWeek.ToString();
            //int today = (int)Enum.Parse(typeof(DaysOfWork), d);
            DaysOfWork office1 = DaysOfWork.Tuesday | DaysOfWork.Wednesday | DaysOfWork.Thursday | DaysOfWork.Friday;
            DaysOfWork office2 = DaysOfWork.Monday | DaysOfWork.Tuesday | DaysOfWork.Wednesday | DaysOfWork.Thursday | DaysOfWork.Friday | DaysOfWork.Saturday | DaysOfWork.Sunday;

            DaysOfWork day = (DaysOfWork)0x0000001;

            bool isOffice1Open = office1 == day;
            bool isOffice2Open = office2 == day;

            Console.WriteLine("Today next offices are working:");
            if (isOffice1Open)
            {
                Console.WriteLine("Office 1");
            }
            if (isOffice2Open)
            {
                Console.WriteLine("Office 2");
            }

        }
    }
}
