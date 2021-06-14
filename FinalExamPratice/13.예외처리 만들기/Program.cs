using System;

namespace _13.예외처리_만들기
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                if (b == 0) throw new Exception("씨팔");
            }
            catch (Exception e) { Console.WriteLine(e); }
            
        }
    }
}
