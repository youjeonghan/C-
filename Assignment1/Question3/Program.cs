using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question3\n");
            // Enter 4 integers
            Console.WriteLine("Input1: For the integer type input");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            // Calculate the largest value
            int max = a > b && a > c ? a : b > c ? b : c;
            max = max > d ? max : d;
            // Calculate the smallest value
            int min = a < b && a < c ? a : b < c ? b : c;
            min = min < d ? min : d;
            // Output Results
            Console.WriteLine("Largest: " + max);
            Console.WriteLine("smallest: " + min + "\n");

            // Enter 4 real number
            Console.WriteLine("Input2: For the double type input");
            double e = Convert.ToDouble(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            double g = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            // Calculate the largest value
            double max2 = e > f && e > g ? e : f > g ? f : g;
            max2 = max2 > h ? max2 : h;
            // Calculate the smallest value
            double min2 = e < f && e < g ? e : f < g ? f : g;
            min2 = min2 < h ? min2 : h;
            // Output Results
            Console.WriteLine("Largest: " + max2);
            Console.WriteLine("smallest: " + min2);
        }
    }
}
