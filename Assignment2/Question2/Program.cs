using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnum = new Random();
            int die1, die2;
            var frequency1 = new int[7];
            var frequency2 = new int[7];


            // Roll two dice 36000 times
            for (var roll=1; roll<=36000; roll++)
            {
                ++frequency1[rnum.Next(1, 7)];
                ++frequency2[rnum.Next(1, 7)];
            }

            // Output Results
            Console.WriteLine("Face Frequency(die1 and die2)");
            for (var num = 1; num<=6; num++)
            {
                Console.WriteLine($"{num,4}  {frequency1[num] + frequency2[num]}");
            }
        }
    }
}
