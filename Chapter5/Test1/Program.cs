using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] arr1 = arr;   // 배열 copy
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
