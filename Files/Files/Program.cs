using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path");
            string path = Console.ReadLine();
            try
            {
                List<string> filesName = new List<string>();
                filesName = Directory.GetFiles(path).ToList<string>();
                Console.WriteLine("Files in directory:");
                foreach (string file in filesName)
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
                Console.WriteLine("Enter name of file");
                string chosFile = Console.ReadLine();
                StreamReader streamReader = new StreamReader(path + chosFile);
                string line;
                line = streamReader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = streamReader.ReadLine();
                }
                streamReader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }     
            Console.ReadLine();
        }
    }
}
