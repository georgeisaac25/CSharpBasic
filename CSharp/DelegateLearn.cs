using System;
namespace CSharp
{
    public class DelegateLearn
    {
        public DelegateLearn()
        {
        }


        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int i1,int i2,Func<int,int,int> f)
        {
            return f(i1, i2);
        }
    }
}
