using System;

namespace RandomNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int face = rand.Next();
            Console.WriteLine(face);
        }
    }
}
