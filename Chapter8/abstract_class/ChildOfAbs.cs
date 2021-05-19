using System;

namespace abstract_class
{
    class ChildOfAbs : ParentAbstract
    {
        //implementation of abstract add method 
        public override void add(int a, int b)
        {
            Console.WriteLine("Add:" + (a + b));
        } //implementation of abstract minus method 
        public override void minus(int a, int b)
        {
            Console.WriteLine("Sub:" + (a - b));
        }
        static void Main(string[] args)
        {
            ChildOfAbs obj = new ChildOfAbs();
            obj.add(10, 20);
            obj.minus(10, 20);
            obj.mul(10, 20);
        }
    }
    
}
