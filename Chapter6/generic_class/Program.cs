using System;
using System.Collections.Generic;

namespace generic_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new list strings 
            var items = new List<string>();
            //display list's count and capacity before adding 
            Console.WriteLine("count before adding:" + items.Count);
            Console.WriteLine("Capacity before adding:" + items.Capacity);
            items.Add("Red"); //append an item to the list 
            items.Insert(0, "yellow"); //insert value at index 0 
            //display list's count and capacity after adding 
            Console.WriteLine("Count after adding:" + items.Count);
            Console.WriteLine("Capacity after adding:" + items.Capacity);
            
            //display using for loop 
            Console.Write("Display using for loop:");
            foreach (var i in items)
            {
                Console.Write(i + " ");
            } 
            
            //display using foreach loop 
            Console.Write("\nDisplay using foreach loop:");
            for (var i = 0; i < items.Count; i++)
            {
                Console.Write(items[i] + " ");
            }
        }
    }
}
