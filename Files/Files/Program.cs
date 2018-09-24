using System;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Files file = new Files();
            Console.WriteLine("Enter path");
            string path = Console.ReadLine();
            try
            {
                file.FilesInDirectory(path);
                Console.WriteLine("Enter name of file");
                string nameOfFile = Console.ReadLine();
                file.ShowFile(path, nameOfFile);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
