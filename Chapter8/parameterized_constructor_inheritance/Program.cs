using System;

namespace parameterized_constructor_inheritance
{
    //parent class 
    class A
    {
        string name;
        int phone;
        protected void getdata()
        {
            name = Console.ReadLine();
            phone = int.Parse(Console.ReadLine());
        }
        protected void display()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Phone:" + phone);
        }
        public A(int a) // constructor 
        {
            Console.WriteLine("This is parent class constructor:" + a);
        }
    }
    //single level inheritance 
    //B is child class, A is parent class 
    class B : A
    {
        int height, weight;
        void getdata1()
        {
            height = int.Parse(Console.ReadLine());
            weight = int.Parse(Console.ReadLine());
        }
        void display1()
        {
            Console.WriteLine("Height:" + height);
            Console.WriteLine("Weight:" + weight);
        }
        B(int a) : base(a) // base 키워드 사용해서 부모클래스 생성자로 인자 넘겨줘야함
        {
            Console.WriteLine("This is child class constructor");
        }
        static void Main(string[] args)
        {
            B obj = new B(100);
            obj.getdata(); //parent class method
            obj.getdata1();
            obj.display(); //parent class method
            obj.display1();
        }
    }
}