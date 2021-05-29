using System;

namespace DivideExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            var loop = true;
            do
            {
                try
                {
                    var num1 = int.Parse(Console.ReadLine());
                    var num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + num1 / num2);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Give integer as an input");
                    //Console.WriteLine(e);
                }
                catch (DivideByZeroException) // 0으로 나누는 예외처리
                {
                    Console.WriteLine("Invalide number");
                    //Console.WriteLine(e);
                }
                catch (Exception e)  // 예외 처리를 모두 포함
                {
                    Console.WriteLine("Exception");
                    //Console.WriteLine(e);
                }
            } while (loop);

        }
    }
}
