using System;

namespace IndexOutOfRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            try
            {
                //try to access the value outside the range 
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i]); //exception thrown 
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("this is finally");
            }
        }
    }
}
