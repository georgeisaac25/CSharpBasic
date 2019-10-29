using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CSharp
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();


            lst.ItemsSource = new List<Contacts>() {
            new Contacts() {
                Name = "Umair", Num = "0456445450945", imgsource = "http://bit.ly/2oDQpPT",
            },
            new Contacts() {
                Name = "Cat", Num = "034456445905", imgsource = "http://gtty.im/2psFEos",
            },
            new Contacts() {
                Name = "Nature", Num = "56445905", imgsource = "http://gtty.im/2psFEos",
            },
};
        }
    }
}
