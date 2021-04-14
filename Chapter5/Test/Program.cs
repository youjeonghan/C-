using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4] { 10, 20, 30, 40 };
            //int[] arr = { 10, 20, 30, 40 };                  // Success
            // int[] arr = new int[] { 10, 20, 30, 40 };        // Success

            // int[] arr = new int[4] { 10, 20, 30, 40, 10};    // Error
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
