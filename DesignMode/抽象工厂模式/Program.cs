using System;

namespace 抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

 
            IFactory_Provider provider = new Person_Gril_Factory();//实例化需要的工厂类
            IPerson person= provider.CreatePerson();//创建相应的实体
            person.SayHi();
            person.Walk();


        }
    }
}
