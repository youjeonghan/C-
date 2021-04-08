using System;

namespace Question4
{
    class Student
    {
        string name;
        int age;
        string id;
        void input()
        {
            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Id: ");
            id = Console.ReadLine();
            Console.WriteLine();
        }

        void output()
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
        static void Main(string[] args)
        {
            Console.WriteLine("Question4\n");

            // Create Object
            Student obj = new Student();
            obj.input();
            obj.output();
        }
    }
}
