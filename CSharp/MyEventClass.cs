using System;
using System.Threading;

namespace CSharp
{
    internal class MyEventClass
    {
        //Define a delegate
        public delegate void CallWSEventHandler(Object o, EventArgs eventArgs);

        //Define event based on that delegate
        public event CallWSEventHandler WSCalled;

        internal void doEvent()
        {
            Console.WriteLine("WS called");
            Thread.Sleep(3000);
            WSDone();
        }

        private void WSDone()
        {
            WSCalled?.Invoke(this, EventArgs.Empty);
        }
    }
}
