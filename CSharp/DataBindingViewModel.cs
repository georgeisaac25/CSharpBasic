using System;

using Xamarin.Forms;

namespace CSharp
{
    public class DataBindingViewModel : ContentPage
    {
        public DataBindingViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

