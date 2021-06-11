using System;
using System.IO; // 추가
namespace StreamWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //sets file to where data is written 
            //use @ so that \ will not consider as escape sequence 
            StreamWriter file = new StreamWriter(@"C:\Dev\Github\C_sharp_progaming\test.txt");
            file.WriteLine("This is seoul");
            file.Close(); //close the stream after writing
        }
    }
}
