using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int space = 5;
            int star = -1;
            for (var i =1; i<=9; i++)
            {
                if (i < 6)
                {
                    space--;
                    star = star + 2;
                }
                else
                {
                    space++;
                    star = star - 2;
                }
                for (var n=0; n<space;n++)
                {
                    Console.Write(" ");
                }
                for (var m = 0; m < star; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
