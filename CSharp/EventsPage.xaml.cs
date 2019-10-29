using System;
using System.Collections.Generic;

using Xamarin.Forms;
using static CSharp.MyEventClass;

namespace CSharp
{
    public partial class EventsPage : ContentPage
    {
        public EventsPage()
        {
            InitializeComponent();
            MyEventClass m = new MyEventClass();

            //AddD callWSEventHandler = (i1, i2) =>
            //{
            //    return i1 + i2;
            //};
            //callWSEventHandler.Invoke(10, 20);

            m.WSCalled += OnWSFinished1;
            m.WSCalled += OnWSFinished2;

            m.SystemWsCalled += OnWSFinished1;

            


            m.doEvent();
            

        }


        public void OnWSFinished1(Object o,EventArgs eventArgs)
        {
            Console.WriteLine("event received1");
        }

        public void OnWSFinished2(Object o, EventArgs eventArgs)
        {
            Console.WriteLine("event received 2");
        }
    }
}
