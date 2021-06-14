using System;
using System.IO;
namespace _15.파일입출력
{
    class Program
    {
        static void Main(string[] args)
        {
            // 파일 읽기
            StreamReader file1 = new StreamReader("C:\\Dev\\Github\\C_sharp_progaming\\test.txt");
            string content = file1.ReadLine();   // 한줄
            Console.WriteLine(content);
            file1.Close();

            // 파일 생성1
            StreamWriter file2 = new StreamWriter(@"C:\Dev\Github\C_sharp_progaming\test.txt");
            file2.WriteLine(content);
            file2.Close();
        }
    }
}
