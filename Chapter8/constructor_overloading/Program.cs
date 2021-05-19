using System;

namespace constructor_overloading
{
    class Parent
    {
        int n1, n2;
        //default constructor 
        public Parent()
        {
            Console.WriteLine("Default constructor is invoked");
        } 
        //parameterized constructor 
        public Parent(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
            Console.WriteLine("Parameterized constructor");
            Console.WriteLine("Invoked value: " + n1 + " and " + n2);
        }
    }
    class Child : Parent
    {
        public Child() : base()
        { 
            //empty body 
        }
        public Child(int i, int j) : base(i, j)
        { 
            //empty body 
        }
        static void Main(string[] args)
        { 
            //invoked constructor with no argument 
            Child obj = new Child();
            //invoked constructor with argument 
            Child obj2 = new Child(100, 500);
        }
    }
}
