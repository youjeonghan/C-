using System;

namespace ReadInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            // string name = Console.ReadLine();
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine(name);
            Console.WriteLine($"Sum: {a + b}");
        }
    }
}
