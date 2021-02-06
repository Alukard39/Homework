using System;
using System.IO;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = GetInput();
            byte[] byteArray = GetByteArray(input);
            File.WriteAllBytes("bytes.bin", byteArray);
            Console.WriteLine("Your data was written to bytes.bin");
        }

        static string[] GetInput()
        {
            Console.WriteLine("Please enter numbers from 0 to 255 with space delimiter:");
            string input = Console.ReadLine();
            string[] stringArray = input.Split(' ');
            return stringArray;
        }

        static byte[] GetByteArray(string[] Array)
        {
            byte[] byteArray = new byte[Array.Length];
            if (CheckQualityOfArray(Array, out string error))
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    byteArray[i] = Convert.ToByte(Array[i]);
                }
                return byteArray;
            }

            else Console.WriteLine($"{error}");
            return byteArray;
        }
        static bool CheckQualityOfArray(string[] array, out string error)
        {
            int[] iarray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                iarray[i] = Convert.ToInt32(array[i]);
            }
            for (int i = 0; i < iarray.Length; i++)
            {
                if (iarray[i] < 0)
                {
                    error = "One of numbers less then 0";
                    return false;
                }
                if (iarray[i] > 255)
                {
                    error = "One of numbers more then 255";
                    return false;
                }                
              }
            error = "";
            return true;
        }
        }
    }
