using System;

namespace test
{
    interface student
    {
        void getInfo();
        void display();
    }
    class computer : student
    {
        string id;
        int weight;
        public void getInfo()
        {
            Console.Write("id : ");
            id = Console.ReadLine();
            Console.Write("weight : ");
            weight = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine($"id: {id} , weight: {weight}");
        }
        static void Main(string[] args)
        {
            computer obj = new computer();
            obj.getInfo();
            obj.display();
        }
    }
    
    
}
