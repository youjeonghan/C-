using System;
using System.IO;
using System.Text; // Encoding
namespace FileStreamWeiteExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //open file with write access 
            FileStream file = new FileStream(@"C:\Dev\Github\C_sharp_progaming\test.txt", FileMode.OpenOrCreate, FileAccess.Write);
            byte[] bdata = Encoding.ASCII.GetBytes("This is little Difficult line");
            //set file to write 
            file.Write(bdata);
            file.Close();
        }
    }
}
