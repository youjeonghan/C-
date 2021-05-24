using System;

namespace hybrid_inheritance
{
    class Child : Interface3
    {
        int n1, n2;
        public void GetNum1()
        {
            n1 = int.Parse(Console.ReadLine());
        }
        public void GetNum2()
        {
            n2 = int.Parse(Console.ReadLine());
        }
        public void Sum()
        {
            Console.WriteLine("Total:" + (n1 + n2));
        }
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.GetNum1();
            obj.GetNum2();
            obj.Sum();
        }
    }
}
