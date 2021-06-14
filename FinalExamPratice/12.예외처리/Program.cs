using System;

namespace _12.예외처리
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1, num2;
                Console.Write("number1 : ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("number2 : ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("끝");
            }

        }
    }
}
