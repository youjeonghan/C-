using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] arr1 = arr;
            arr[0] = 100;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
        }
    }
}
