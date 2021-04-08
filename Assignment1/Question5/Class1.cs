using System;
using System.Collections.Generic;
using System.Text;

namespace Question5
{
    class Class1
    {
        // This file should have a fields and methods
        string name;
        int age;
        string id;
        public void input()
        {
            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Id: ");
            id = Console.ReadLine();
            Console.WriteLine();
        }

        public void output()
        {
            string prefix = null;
            if (age > 18)
            {
                prefix = "adult";
            }
            else
            {
                prefix = "under age";
            }
            Console.WriteLine($"{prefix} {age} {name} {id}");
        }
    }
}
