using System;
using System.IO;

namespace FileCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            //sets file to where data is read 
            StreamReader file = new StreamReader("C:\\Dev\\Github\\C_sharp_progaming\\test.txt");
            //read from the file 
            string name = file.ReadLine();
            Console.WriteLine(name); //display the same content on console 
            file.Close();
        }
    }
}
