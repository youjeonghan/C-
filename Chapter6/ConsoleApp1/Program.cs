using System;
using System.Linq;  // 추가해줘야함

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };
            Console.Write("Original array: ");
            //display orginal array 
            foreach (var i in values)
            {
                Console.Write(i + " ");
            }

            //query for filter number greater than 4 
            var filtered = from value in values //data source is values 
                           where value > 4
                           select value;
            Console.Write("\n" + "Array value greater than 4: ");
            foreach (var i in filtered)
            {
                Console.Write(i + " ");
            }
        }
    }
}
