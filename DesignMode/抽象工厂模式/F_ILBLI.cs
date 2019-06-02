using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{

    public interface IFactory_Provider 
    {
        IPerson CreatePerson();
    }
  

    public class Person_Gril_Factory : IFactory_Provider
    {
        public IPerson CreatePerson()
        {
            return new Girl();
        } 
    }


    public class Person_Boy_Factory : IFactory_Provider
    {
        public IPerson CreatePerson()
        {
            return new Boy();
        }
    }
     
}
