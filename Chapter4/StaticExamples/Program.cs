using System;

namespace StaticExamples
{
    class Program
    {
        static string name;
        int age;
        void input(string family, int age)  // non static
        {
            name = family;
            this.age = age;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.input("Michel", 14);
            Console.WriteLine(Program.name + "\n" + obj.age);
        }
    }
}
