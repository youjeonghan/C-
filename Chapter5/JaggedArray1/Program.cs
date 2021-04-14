using System;

namespace JaggedArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] c = new int[4][];
            c[0] = new int[3] { 2, 5, 6 };
            c[1] = new int[4] { 10, 32, 45, 54 };
            c[2] = new int[1] { 6 };
            c[3] = new int[2] { 2, 5 };

            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < c[i].Length; j++)
                {
                    Console.Write(c[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}

