using System;

namespace mutiple_inheritance
{
    // implements Iparent interface 
    // extends parent class Branch
    class Child : Branch, Iparent //write class first and interface 
    {
        int id;
        string name;
        public void getdata()
        {
            name = "David";
            id = 2020;
            getPlace();
        }
        void display()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
        }
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.getdata();
            obj.display();
        }
    }
}
