using System;

namespace Question4
{
    class Person
    {
        static string name;
        static string id;
        static double temeprature;
        public static void getdata()
        {
            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Id: ");
            id = Console.ReadLine();

            Console.Write("Body Temeprature: ");
            temeprature = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public static void putdata()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Id: {id}");
            string mention = temeprature > 37.2 ? "Sorry, you can’t board" : "you can board";
            Console.WriteLine(mention);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person.getdata();
            Person.putdata();
        }
    }
}
