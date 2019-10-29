using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CSharp
{
    public partial class DatabindingPage : ContentPage
    {
        public DatabindingPage()
        {
            InitializeComponent();
            BindingContext = new DataBindingViewModel();

            

            MessagingCenter.Subscribe<string, string>("MyApp", "NotifyMsg", (sender, arg) =>
            {
                Console.WriteLine("*******" +arg);

            });

        }
    }
}
