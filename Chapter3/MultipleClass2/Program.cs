using System;

namespace MultipleClass2
{
    class Test
    {
        string name;
        public void input()
        {
            name = "University";
            Console.WriteLine(name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            obj.input();
        }
    }
}
