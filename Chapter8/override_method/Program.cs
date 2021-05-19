using System;

namespace override_method
{
    class Parent
    {
        public virtual void input() //use of virtual in base class 
        {
            Console.WriteLine("this is parent class input method");
        }
    }
    class Child : Parent
    { 
        //same method of the super class is used 
        public override void input() //use of overriding in child class
        {
            base.input(); // call the base class method
            Console.WriteLine("this is child class input method");
        }
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.input(); //calling input() of child
        }
    }
}
