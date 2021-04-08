using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleClass2
{
    class Class1
    {
        string name;
        int id;
        internal void input()
        {
            name = Console.ReadLine();
            id = int.Parse(Console.ReadLine());
        }
        internal void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
        }
    }
}
