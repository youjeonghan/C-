using System;
using System.IO;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter a value to save to the console
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your id : ");
            string id = Console.ReadLine();
            Console.Write("Enter your Age : ");
            string age = Console.ReadLine();

            // Save variables as .txt
            StreamWriter file1 = new StreamWriter(@"C:\Dev\Github\C_sharp_progaming\test.txt");
            file1.WriteLine($"NAME:{name}");
            file1.WriteLine($"ID:{id}");
            file1.WriteLine($"AGE:{age}");
            file1.Close();

            // Read the .txt file and output it to the console
            StreamReader file2 = new StreamReader(@"C:\Dev\Github\C_sharp_progaming\test.txt");
            string content = file2.ReadToEnd();
            Console.WriteLine(content);
            file2.Close();
        }
    }
}
