using System;
using System.Linq;

namespace LINQ_orderby
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5, 10};
            Console.Write("Original array: ");
            //display orginal array 
            foreach (var i in values)
            {
                Console.Write(i + " ");
            }

            //query for filter number greater than 4 
            var filtered = from value in values
                           where value > 4 && value<10
                           orderby value
                           //orderby value    // by default will ascending
                           //orderby value descending
                           //orderby value ascending
                           select value;
            Console.Write("\n" + "Array value greater than 4: ");
            foreach (var i in filtered)
            {
                Console.Write(i + " ");
            }
        }
    }
}
