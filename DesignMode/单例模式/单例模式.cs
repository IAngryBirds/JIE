using System;
using System.Collections.Generic;
using System.Text;

namespace 单例模式
{
    public class Person
    {
        public string UID = Guid.NewGuid().ToString();
        private Person() { } 

        private static Lazy<Person> lazy =new Lazy<Person>(() => new Person());

        public static Person Instance { get { return lazy.Value; } }
         

        public void SayHi()
        {
            Console.WriteLine($"您好_{UID}");
        }

    }
}
