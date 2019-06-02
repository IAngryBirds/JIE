using System;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person.Instance.SayHi();

            Person.Instance.SayHi();

            Person.Instance.UID = Guid.NewGuid().ToString();

            Person.Instance.SayHi();

            Console.ReadKey();

        }
    }
}
