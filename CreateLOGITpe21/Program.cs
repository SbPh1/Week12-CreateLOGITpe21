using System;
using System.IO;

namespace CreateLOGITpe21
{
    class Program
    {
        static void Main(string[] args)
        {

            string newDiretory = "LOGITpe21";

            CreateMyDirectory(newDiretory);
           
        }
        private static void CreateMyDirectory(string myDirectoryName)
        {
            string rootDirectory = @"C:\Users\Monkey\samples";
            string directoryFullPath = $@"{rootDirectory}\{myDirectoryName}";

            if (Directory.Exists(directoryFullPath))
            {
                Console.WriteLine($"Directory {myDirectoryName} already exists in {directoryFullPath}.");
            }

            else
            {
                Directory.CreateDirectory(directoryFullPath);
                Console.WriteLine($"Directory {myDirectoryName} has been created.");
            }
        }


    }
}
