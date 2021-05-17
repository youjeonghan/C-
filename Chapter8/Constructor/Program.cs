using System;

namespace Constructor
{
    class Constructor
    {
        int a, b;
        Constructor() //constructor { a = 10;
        {
            a = 10;
            b = 20;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void Main(string[] args)
        {
            Constructor obj = new Constructor();
        }
    }
}