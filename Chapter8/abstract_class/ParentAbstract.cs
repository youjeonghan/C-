using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_class
{
    //class contains abstract and non abstract method 
    abstract class ParentAbstract
    {
        public abstract void add(int a, int b); //abstract methods 
        public abstract void minus(int a, int b);
        public void mul(int a, int b) //non abstract method 
        {
            Console.WriteLine("Mul:" + (a * b));
        }
    }
}
