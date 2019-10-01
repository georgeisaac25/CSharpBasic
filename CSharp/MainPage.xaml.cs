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

    public delegate int AddD(int a, int b);
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

			MyMethod();
			Console.WriteLine("***********Hello World!");
			Console.WriteLine("***********Hello World!");

            DelegateLearn delegateLearn = new DelegateLearn();

            AddD d1 = new AddD(delegateLearn.Add);
            var a1 = d1(10, 20);
            Console.WriteLine("***********Add!"+a1);

            AddD d2 = delegate(int a,int b) {

                return a + b;
	        };

            var a2 = d2.Invoke(10, 30);
            Console.WriteLine("***********Add!" + a2);


            Func<int,int,int> funcCall1 = (i1,i2) => {
                return i2 + i1;
            };
            var a3 = funcCall1(100, 200);
            Console.WriteLine("***********Add!" + a3);

            var a4 = delegateLearn.Add(40,50,(i1, i2) => {
                return i2 + i1;
            });
            Console.WriteLine("***********Add!" + a4);


        }



        public async static Task MyMethod()
		{
			await Task.Delay(5000); //Task.Run(() => CallAsyncMethod());
			Console.WriteLine("*********sleep World!");

		}

		
	}
}
