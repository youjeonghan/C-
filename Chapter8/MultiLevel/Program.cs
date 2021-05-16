using System;

namespace MultiLevel
{
    class Students
    {
        int id;
        string name;
        public void getInfo()
        {
            Console.WriteLine("Enter Student detail:");
            name = Console.ReadLine();
            id = int.Parse(Console.ReadLine());
        }
        public void putInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
        }
    }
    class ComputerStu : Students
    {
        int m1, m2;
        public void getmark()
        {
            Console.WriteLine("Enter two subject mark:");
            m1 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
        }
        public void putmark()
        {
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine("Total:" + (m1 + m2));
        }
    }
    class Display : ComputerStu
    {
        void display()
        {
            Console.WriteLine("****Output***");
            putInfo();
            putmark();
        }
        static void Main(string[] args)
        {
            Display obj = new Display();
            obj.getInfo();
            obj.getmark();
            obj.display();
        }
    }
}
