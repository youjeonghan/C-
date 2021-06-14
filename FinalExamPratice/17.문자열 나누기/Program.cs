using System;

namespace _17.문자열_나누기
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ch = { 'h', 'i', ' ', 'A' };

            var string1 = new string(ch);
            var string2 = new string(ch,3,1);
            var string3 = new string('1', 3);
            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);
        }
    }
}
