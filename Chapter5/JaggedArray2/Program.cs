using System;

namespace JaggedArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] rect = { { 1, 2, 3 }, { 4, 5, 6 } };

            int[][] jagged =
            {
                new int[] {1,2 },
                new int[] {3},
                new int[] {4,5,6}
            };
            OutputArray(rect);
            OutputArray(jagged);
        }
        static void OutputArray(int[,] array)
        {
            Console.WriteLine("rext");
            for ( var row =0; row < array.GetLength(0); row++)
            {
                for (var colum = 0; colum < array.GetLength(1); colum++)
                {
                    Console.Write($"{array[row, colum]}  ");
                }
                Console.WriteLine();
            }
        }
        static void OutputArray(int[][] array)
        {
            Console.WriteLine("rext");
            foreach (var row in array)
            {
                foreach (var element in row)
                {
                    Console.Write($"{element}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
