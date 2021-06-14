using System;

namespace _18.string_각종_메서드
{
    class Program
    {
        static void Main(string[] args)
        {
            String txt = "Helllol";
            char[] search = { 'e', 'l' };
            Console.WriteLine(txt.Length);      // 문자열 길이
            Console.WriteLine(txt[1]); 
            Console.WriteLine(txt.IndexOf("l")); // 해당 글자의 인덱스 번호
            Console.WriteLine(txt.IndexOf("l", 1));
            Console.WriteLine(txt.IndexOf("l", 3)); // 인덱스 3부터
            Console.WriteLine(txt.IndexOf("l", 4,1)); // 인덱스 4부터 1번 찾음(자기자리포함)
            Console.WriteLine(txt.LastIndexOf("l"));
            Console.WriteLine(txt.IndexOfAny(search));  // 여러개중 찾기
            Console.WriteLine(txt.LastIndexOfAny(search));

            var txt2 = new char[5] { 'x', 'x', 'x', 'x', 'x' };
            txt.CopyTo(3, txt2, 3, 2);  // txt 인덱스3부터, txt2에, 인덱스 3부터, 2번 복사
            Console.WriteLine(txt2);


            String txt3 = "Hello";
            String txt4 = "World";
            Console.WriteLine(txt3.Substring(1));   // 앞에서 1개 짜르고 출력
            Console.WriteLine(txt3.Substring(0,2)); // 인덱스0~2 출력
            Console.WriteLine(string.Concat(txt3,txt4));    // 합치기
            Console.WriteLine(txt3.Replace('l','L'));       // l을 L 로 치환

            String txt5 = "   Asd   ";
            Console.WriteLine(txt5.Trim());     // 공백 자르기
            Console.WriteLine(txt5.ToLower());
            Console.WriteLine(txt5.ToUpper());
        }
    }
}
