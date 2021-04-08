using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleClass2
{
    class Class1
    {
        string name;
        int id;
        public void input()
        {
            name = Console.ReadLine();
            id = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
        }
    }
}
