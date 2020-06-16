using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public class HourlyEmployee : Employee
    {
        public decimal hourlyPay;
        public decimal hoursWorked;
        public decimal weeklyPay;
        public decimal fica;
        public decimal federalTax;
        public decimal net;
        public HourlyEmployee(int age, int employeeID, string firstName, string lastName, decimal hourlyPay, decimal hoursWorked) : base(age, employeeID, firstName, lastName)
        {
            weeklyPay = hourlyPay * hoursWorked;
            fica = Math.Round(weeklyPay * .0765m, 2);
            federalTax = Math.Round(weeklyPay * .265m, 2);
            this.hourlyPay = hourlyPay;
            this.hoursWorked = hoursWorked;
        }
        public override string CalculatePay()
        {
            net = weeklyPay - fica - federalTax;
            return net.ToString("C2");
        }
    }
}