using System.Collections.Generic;

namespace CSharp
{
    public class Employee
    {
        public int salary;
        public string designation;

        public Employee(int salary,string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }

        public bool IsEligibleForPromotion(Employee employee,IsEligibleDelegate isEligibleDelegate)
        {
            return isEligibleDelegate.Invoke(employee);
        }

        //public bool IsEligibleForPromotionBasedOnSalary(Employee employee)
        //{
        //    return employee.salary>1000;
        //}

        //public bool IsEligibleForPromotionBasedOnDesignation(Employee employee)
        //{
        //    return employee.designation.Equals("Architect");
        //}

    }
}