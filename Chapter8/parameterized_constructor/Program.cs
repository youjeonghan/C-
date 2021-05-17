using System;

namespace parameterized_constructor
{
    class Program
    {
        String name;
        int id;
        Program(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        static void Main(string[] args)
        {
            Program obj = new Program("Sejong", 2020);
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.id);
        }
    }
}
