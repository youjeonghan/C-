using System;

namespace MethodOverloading1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.input(7);
            obj.input(10, 10.5);
            obj.input(10, 10);
        }
        void input(int x)
        {
            Console.WriteLine("Output1: " + (x+x));
        }
        void input(int x, double y)
        {
            Console.WriteLine("Output2: " + (x + y));
        }
        void input(int x, int y)
        {
            Console.WriteLine("Output3: " + (x + y));
        }
    }
}
