using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DoesNotThrowException();
        }
        static void DoesNotThrowException()
        {
            try
            {
                Console.WriteLine("In DoesNotThrowException");
                throw new Exception("에러쥰내발생");
            }
            catch
            {
                Console.WriteLine("never");
            }
        }
    }
    
}
