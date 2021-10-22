using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOOperation
{
    class StreamReaderDemo
    {

        public void ReadFromStreamReader()
        {
            string Path = @"C:\Users\nandi\source\repos\FileIOOperation\Example.txt";

            using (StreamReader sr = File.OpenText(Path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine();
                }
            }
        }

        public void WriteUsingStreamWriter()
        {
            string Path = @"C:\Users\nandi\source\repos\FileIOOperation\Example.txt";

            using (StreamWriter sr=File.AppendText(Path))
            {
                sr.WriteLine("Hello added text using STREAM writer");
                sr.Close();

                Console.WriteLine(File.ReadAllText(Path));
            }
        }
    }
}
