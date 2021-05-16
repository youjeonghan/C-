using System;

namespace Test
{
    // sealed class A   // 이러면 상속못함
    class A //parent class 
    {
        public void display1()
        {
            Console.WriteLine("Parent class display1");
        }
        public void display2()
        {
            Console.WriteLine("Parent class display2");
        }
    }
    //child class 
    class B : A //inheritance 
    {
        void display3()
        {
            Console.WriteLine("child class");
        }
        static void Main(string[] args)
        {
            B obj = new B();
            obj.display1();
            obj.display2();
            obj.display3();
        }
    }

}