﻿using System;


namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}, today is {DateTime.Now.ToString("d MMMM yyyy")}");
        }

    }
}