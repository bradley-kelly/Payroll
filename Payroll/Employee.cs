using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public abstract class Employee
    {
        protected int age;
        protected int employeeID;
        protected string firstName;
        protected string lastName;
            
        protected Employee(int age, int employeeID, string firstName, string lastName)
        {
            this.age = age;
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public int Age { get { return age; } }
        public int EmployeeID { get { return employeeID; } }
        public string Name { get { return lastName + ", " + firstName; } }       
        public abstract string CalculatePay();
    }
}