using System;

using Xamarin.Forms;

namespace CSharp
{
    public class Contacts : ContentPage
    {
        public Contacts()
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

