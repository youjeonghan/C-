using System;
using System.IO;

namespace FileStreamReadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            FileStream file;
            //use @ so that \ will not consider as escape sequence 
            //open file with read access 
            file = new FileStream(@"C:\Dev\Github\C_sharp_progaming\test.txt", FileMode.Open, FileAccess.Read);
            //sets file from where data is read 
            StreamReader writer = new StreamReader(file);
            name = writer.ReadToEnd();
            Console.WriteLine(name); //display on console 
            writer.Close(); //stream is close
        }
    }
}
