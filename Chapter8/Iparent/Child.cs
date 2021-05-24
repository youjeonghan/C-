using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iparent
{
    class Child : Iparent, Iparent1
    {
        public void sum(int a, int b) //implementation of interface 
        {
            Console.WriteLine("Add:" + (a + b));
        }
        public void sub(int a, int b) //implementation of interface 
        {
            Console.WriteLine("Sub:" + (a - b));
        }
        public void mul(int a, int b)
        {
            Console.WriteLine("Mul:" + (a * b));
        }
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.sum(20, 30);
            obj.sub(10, 30);
            obj.mul(10, 20);
        }
    }
}
