using System;

namespace Constructor1
{
    class Person
    {
        string name;
        int id;
        public Person(string name, int id)
        {
            this.name = name;   // 인자의 이름이 인스턴스 변수와 다르면 this. 사용안해도 가능 ex) string a -> name = a;
            this.id = id;
            Console.WriteLine(name+"\n"+id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person("Michel", 2021);
        }
    }
}
