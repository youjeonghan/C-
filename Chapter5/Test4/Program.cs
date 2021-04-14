// 배열에 var 사용
// var 배열 초기화
using System;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];
            //var arr1 = { 1, 2, 3 };   //Error
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
