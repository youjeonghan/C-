// 배열 사이즈 바꾸기, for / foreach 사용법
using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            Array.Resize(ref arr, 5);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i=0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
