using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CSharp
{
    public delegate bool IsEligibleDelegate(Employee employee);

    public delegate int AddD(int a, int b);


    public partial class DelegateLearnPage : ContentPage
    {
        public DelegateLearnPage()
        {
            InitializeComponent();

            Employee employee1 = new Employee(10,"Designer");
            Employee employee2 = new Employee(100, "Architect");

            //in normal method call.
            employee1.IsEligibleForPromotionBasedOnSalary(employee1);

            
            // we can pass the method in the form of delegate.
            employee1.IsEligibleForPromotion(employee1, delegate (Employee employee)
            {
                return employee.designation.Equals("Architect");
            });


            employee2.IsEligibleForPromotion(employee2, delegate (Employee employee)
            {
                return employee.salary > 1;
            });




        }
    }
}
