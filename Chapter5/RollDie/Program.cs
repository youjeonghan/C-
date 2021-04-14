using System;

namespace RollDie
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumbers = new Random();
            var frequency = new int[7];
            Console.WriteLine($"{"face",4}{"frequency",10}");
            for (var face = 0; face < frequency.Length; ++face)
            {
                Console.WriteLine($"{face,4}{frequency[face],10}");
            }


            for (var roll = 1; roll<60000000; ++roll)
            {
                ++frequency[randomNumbers.Next(1, 7)];
            }
            Console.WriteLine($"{"face",4}{"frequency",10}");
            for (var face = 0; face < frequency.Length; ++face)
            {
                Console.WriteLine($"{face,4}{frequency[face],10}");
            }
        }
    }
}
