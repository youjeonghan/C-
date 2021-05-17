using System;

namespace parameterized_constructor2
{
    class Program
    {
        String name;
        int id, age;
        Program(String name, int id) //parametrized constructor with 2 parameters 
        {
            this.name = name;
            this.id = id;
        }
        Program(String name, int id, int age) //parametrized constructor with 3 parameters 
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }
        void display1()
        {
            Console.WriteLine(name + " " + id);
        }
        void display2()
        {
            Console.WriteLine(name + " " + id + " " + age);
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program("David", 2020); //invoked constructor with 2 parameter 
            Program obj2 = new Program("Michel", 1920, 80); //invoked constructor with 2 parameter 
            obj1.display1();
            obj2.display2();
        }
    }
}
