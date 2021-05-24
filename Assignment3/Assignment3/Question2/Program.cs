using System;

namespace Question2
{
    interface A
    {
        public void Check_A();
    }
    class B : A
    {
        public void Check_A()   // implementation of interface A
        {
            Console.WriteLine("This is A method");
        }

        public void Check_B()
        {
            Console.WriteLine("This is B method");
        }
    }
    interface C : A
    {
        public void Check_C();
    }
    class D: B, C    // Order is Class, Interface
    {
        public void Check_C() // implementation of interface C
        {
            Console.WriteLine("This is C method");
        }
        void Check_D()
        {
            Console.WriteLine("This is D method");
        }

        static void Main(string[] args)
        {
            // Hybrid inheritance Normal Results
            D obj = new D();
            obj.Check_A();
            obj.Check_B();
            obj.Check_C();
            obj.Check_D();
        }
    }
}
