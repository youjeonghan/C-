using System;

namespace _2d_arraay_example15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
