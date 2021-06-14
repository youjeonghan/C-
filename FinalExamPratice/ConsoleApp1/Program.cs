using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<string>();
            Console.WriteLine($"{items.Count} {items.Capacity}");
            items.Add("red");               // red
            items.Insert(0, "yellow");      // yellow, red
            items.Add("green");             // yellow, red, green
            items.Add("green");             // yellow, red, green, green
            items.Add("green");             // yellow, red, green, green, green
            items.Remove("yellow");         // red, green, green, green       (여러개면 첫번째로나오는거 지움)
            items.Remove("green");         // red, green, green
            items.Remove("green");         // red, green
            items.RemoveAt(1);              // red          (인덱스 1 인거 지움)
            Console.WriteLine($"{items.Count} {items.Capacity}");
            Console.WriteLine(items.Contains("red"));
            Console.WriteLine(items.Contains("black"));
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
