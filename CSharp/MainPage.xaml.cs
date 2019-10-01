using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

			MyMethod();
			Console.WriteLine("***********Hello World!");
			Console.WriteLine("***********Hello World!");
        }



        public async static Task MyMethod()
		{
			await Task.Delay(5000); //Task.Run(() => CallAsyncMethod());
			Console.WriteLine("*********sleep World!");

		}

		
	}
}
