using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnum = new Random();
            // Output from 0 to 24
            Console.WriteLine("0 to 24 : " + rnum.Next(0, 25));

            // Output from 1 to 6
            Console.WriteLine("1 to 6 : " + rnum.Next(1, 7));

            // Output from 10 to 109
            Console.WriteLine("10 to 109 : " + rnum.Next(10, 110));

            // Output from 100 to 149
            Console.WriteLine("100 to 149 : " + rnum.Next(100, 150));

            // Output from - 5 to 4
            Console.WriteLine("- 5 to 4 : " + rnum.Next(-5, 5));

            // Output from 12 to 33
            Console.WriteLine("12 to 33 : " + rnum.Next(12, 34));
        }
    }
}
