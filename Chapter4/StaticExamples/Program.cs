using System;

namespace StaticExamples
{
    class Program
    {
        static string name;
        static int age;
        static void input(string family, int a)  // non static
        {
            name = family;
            age = a;
        }
        static void Main(string[] args)
        {
            Program.input("Michel", 14);
            Console.WriteLine(Program.name + "\n" + age);
        }
    }
}
