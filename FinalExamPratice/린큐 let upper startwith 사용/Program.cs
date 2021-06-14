using System;
using System.Linq;
using System.Collections.Generic;

namespace 린큐_let_upper_startwith_사용
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string>();
            values.Add("red");               // red
            values.Add("black");             // red, black
            var filtered = from value in values
                           let upper = value.ToUpper()  // let: 임시변수 / ToUpper: 문자열 대문자로 치환
                           where (value =="black" && upper == "BLACK") || upper == "RED"    // 조건절
                           where upper.StartsWith("B")  // "R" 로 시작하면 True
                           orderby value        //  default ascending
                           //orderby value descending
                           //orderby value ascending
                           select upper;
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
        }
    }
}
