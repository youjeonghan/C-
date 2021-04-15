using System;
using System.Collections.Generic;

namespace Generic_class1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new list strings 
            var items = new List<string>();
            items.Add("Red"); //append an item to the list 
            items.Insert(0, "yellow"); //insert value at index 0 
            items.Add("Green");
            items.Add("yellow");

            Console.Write("Display before removing:");
            foreach (var i in items)
            {
                Console.Write(i + " ");
            }

            items.Remove("yellow");//remove the first yellow 
            Console.Write("\nDisplay after removing yellow:");
            foreach (var i in items)
            {
                Console.Write(i + " ");
            }
            items.RemoveAt(1);//remove item at index 1 
            Console.Write("\nDisplay after removing index 1:");
            foreach (var i in items)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
