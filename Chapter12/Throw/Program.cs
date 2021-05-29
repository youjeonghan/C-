using System;

namespace Throw
{
    class ExceptionExample
    {
        int a, b, result = 0;
        public void display()
        {
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                //throw the custom messsage from programmer 
                if (b == 0) throw new Exception("Divide by zero"); //new exception is thrown 
                result = a / b;
                Console.WriteLine("Result:" + result);
            }
            catch (Exception e) //catch the explicit exception 
            {
                Console.WriteLine(e.Message);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionExample obj = new ExceptionExample();
            obj.display();
        }
    }
}
