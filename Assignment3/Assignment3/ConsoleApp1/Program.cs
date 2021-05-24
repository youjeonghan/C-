using System;

namespace Question1
{
    class Parent // parent class 
    {
        public int a, b;
        // a,b input method
        public void input1()
        {
            Console.Write("input a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("input b: ");
            b = int.Parse(Console.ReadLine());
        }
    }
    //child class 
    class Child : Parent // single level inheritance 
    {
        int c,d;
        // c,d input method
        void input2()
        {
            Console.Write("input c: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("input d: ");
            d = int.Parse(Console.ReadLine());
        }
        // output method
        void display()
        {
            Console.WriteLine($"a is {a}");
            Console.WriteLine($"b is {b}");
            Console.WriteLine($"c is {c}");
            Console.WriteLine($"d is {d}");
            Console.WriteLine($"sum is {a+b+c+d}");
        }
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.input1();
            obj.input2();
            obj.display();
        }
    }
}