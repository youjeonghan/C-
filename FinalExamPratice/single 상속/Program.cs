using System;

namespace single_상속
{
    class A
    {
        public string a = "asd";
        public void display1() { Console.WriteLine("parent"); }
    }
    class B:A
    {
        public void display2() { Console.WriteLine("child"); }

        static void Main(string[] args)
        {
            B obj = new B();
            obj.display1();
            obj.display2();
        }
    }
}
