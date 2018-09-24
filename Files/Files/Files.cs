using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Files
{
    class Files
    {
        public void FilesInDirectory(string path)
        {
            List<string> filesName = Directory.GetFiles(path).ToList();
            Console.WriteLine("Files in directory");
            foreach (string file in filesName)
            {
                Console.WriteLine(file);
            }
        }

        public void ShowFile(string path, string name)
        {
           using(StreamReader streamReader = new StreamReader(path + name))
            {
                string line;
                line = streamReader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = streamReader.ReadLine();
                }
            }  
        }
    }
}
