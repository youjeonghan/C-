using System;

namespace _19.비교_메서드
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = "aaa";
            var string2 = "bbb";
            Console.WriteLine(string.Equals(string1, "aaa"));
            Console.WriteLine(string1.Equals("aaa"));
            Console.WriteLine(string1=="aaa");

            Console.WriteLine(string1.CompareTo(string2));
            Console.WriteLine(string2.CompareTo(string1));
            Console.WriteLine(string1.StartsWith("a")); // True
            Console.WriteLine(string1.EndsWith("a")); // True

        }
    }
}
