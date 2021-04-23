using System;
using System.Linq;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize the one-dimensional array of size 10
            var arr = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

            // Display the original array.
            Console.Write("Original array: ");
            foreach (var i in arr)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();

            // Using the LINQ, filtering to filter out the even number in the array excluding 0
            var b = from target in arr
                    where target > 0 && target%2==0
                    orderby target
                    select target;
            Console.Write("Array with even number: ");
            foreach (var i in b)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Using the LINQ, sort original array in descending order.
            var c = from target in arr
                    orderby target descending
                    select target;
            Console.Write("Original array, sorted in descending order: ");
            foreach (var i in c)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Using the LINQ, filtered value obtained in part (b) to sort in a descending order
            var d = from target in arr
                    where target > 0 && target % 2 == 0
                    orderby target descending
                    select target;
            Console.Write("Sorted array from (b) in descending order: ");
            foreach (var i in d)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Using the LINQ, original array to sort the value greater than 5 in descending order
            var e = from target in arr
                    where target > 5
                    orderby target descending
                    select target;
            Console.Write("Array greater than 5, sorted in descending order: ");
            foreach (var i in e)
            {
                Console.Write(i + " ");
            }
        }
    }
}
