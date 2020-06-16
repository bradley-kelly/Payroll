using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public class SalariedEmployee : Employee
    {
        public decimal monthlyPay;
        public decimal weeklyPay;
        public decimal fica;
        public decimal federalTax;
        public decimal net;
        public SalariedEmployee(int age, int employeeID, string firstName, string lastName, decimal monthlyPay) : base(age, employeeID, firstName, lastName)
        {
            weeklyPay = (monthlyPay * 12) / 52;
            fica = Math.Round(weeklyPay * .0765m, 2);
            federalTax = Math.Round(weeklyPay * .265m, 2);
            this.monthlyPay = monthlyPay;
        }
        public override string CalculatePay()
        {
            net = weeklyPay - fica - federalTax;
            return net.ToString("C2");
        }
    }
}