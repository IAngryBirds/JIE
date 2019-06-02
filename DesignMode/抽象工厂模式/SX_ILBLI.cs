using System;

namespace 抽象工厂模式
{
    public class Girl : IPerson
    {
        public void SayHi()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }


    public class Boy : IPerson
    {
        public void SayHi()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }

}
