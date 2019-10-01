using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CSharp
{
    public partial class EventsPage : ContentPage
    {
        public EventsPage()
        {
            InitializeComponent();
            MyEventClass m = new MyEventClass();

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
