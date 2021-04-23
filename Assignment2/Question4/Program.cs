using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter an array size
            Console.Write("Enter size: ");
            var size = int.Parse(Console.ReadLine());
            Console.WriteLine($"The size of the array: {size}");

            // Array Declaration
            double[] arr = new double[size];

            // Enter Array Elements
            for (var i = 0; i < size; i++)
            {
                Console.Write($"Enter number {i+1}: ");
                arr[i] = double.Parse(Console.ReadLine());
            }

            // Reversed Result Output
            Console.WriteLine("The numbers in reverse order:");
            for (var i = size-1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
