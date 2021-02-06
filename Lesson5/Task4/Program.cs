using System;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preparing for folders scaning!");
            Console.WriteLine("Enable recursive method? (Y or N)");
            string answer = Console.ReadLine();
            if(answer == "Y")
            {
                RecursiveFolderList();
            }
            if(answer == "N")
            {
                FolderList(out string message);
                Console.WriteLine(message);
            }
            else
            {
                throw new Exception("ERROR! Wrong working mode!");
            }                
        }
        static string RecursiveFolderList()
        {
            //с рекурсией пока не придумал
            return "";
        }
        static string FolderList(out string message) 
        {
            string fileName = "folderlist.txt";
            string[] dir = Directory.GetDirectories(@"C:\Test", "*");
            for (int i = 0; i < dir.Length; i++)
            {
                File.AppendAllText(fileName, dir[i]);
                File.AppendAllText(fileName, Environment.NewLine);
            }
            string[] files = Directory.GetFiles(@"C:\Test");
            for (int i = 0; i < files.Length; i++)
            {
                File.AppendAllText(fileName, files[i]);
                File.AppendAllText(fileName, Environment.NewLine);
            }
            message = $"List of folder was written to {fileName}";
            return message;
        }
    }
}
