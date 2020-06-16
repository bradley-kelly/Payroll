using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public class Report
    {
        public static string RunReport(List<Employee> list)
        {
            StringBuilder sb = new StringBuilder();
            decimal ficaHourly = 0m;
            decimal federalHourly = 0m;
            decimal grossHourly = 0m;
            decimal netHourly = 0m;
            decimal ficaSalary = 0m;
            decimal federalSalary = 0m;
            decimal grossSalary = 0m;
            decimal netSalary = 0m;

            foreach (Employee emp in list)
            {
                sb.Append("Employee Weekly Summary:\n");
                sb.Append("Employee Name: " + emp.Name + "\n");
                sb.Append("Employee Age: " + emp.Age + "\n");
                sb.Append("Employee ID: " + emp.EmployeeID + "\n");

                if (emp is SalariedEmployee)
                {
                    SalariedEmployee sPay = emp as SalariedEmployee;

                    sb.Append("Employee Monthly Pay: " + sPay.monthlyPay.ToString("C2") + "\n");
                    sb.Append("Employee FICA Tax: " + sPay.fica.ToString("C2") + "\n");
                    sb.Append("Employee Federal Tax: " + sPay.federalTax.ToString("C2") + "\n");
                    sb.Append("Employee Weekly Net Payroll: " + sPay.CalculatePay() + "\n");
                    sb.Append("" + "\n");

                    ficaSalary += Math.Round(sPay.fica, 2);
                    federalSalary += Math.Round(sPay.federalTax, 2);
                    grossSalary += sPay.weeklyPay;

                }
                netSalary = grossSalary - ficaSalary - federalSalary;

                if (emp is HourlyEmployee)
                {
                    HourlyEmployee hPay = emp as HourlyEmployee;

                    sb.Append("Employee Hourly Pay: " + hPay.hourlyPay.ToString("C2") + "\n");
                    sb.Append("Employee Hours Worked: " + hPay.hoursWorked.ToString() + "\n");
                    sb.Append("Employee FICA Tax: " + hPay.fica.ToString("C2") + "\n");
                    sb.Append("Employee Federal Tax: " + hPay.federalTax.ToString("C2") + "\n");
                    sb.Append("Employee Weekly Net Payroll: " + hPay.CalculatePay() + "\n");
                    sb.Append("" + "\n");

                    ficaHourly += Math.Round(hPay.fica, 2);
                    federalHourly += Math.Round(hPay.federalTax, 2);
                    grossHourly += hPay.weeklyPay;
                }
                netHourly = grossHourly - ficaHourly - federalHourly;
            }
            sb.Append("Salaried Employee Weekly Summary:" + "\n");
            sb.Append("Gross Payroll: " + grossSalary.ToString("C2") + "\n");
            sb.Append("Net Payroll: " + netSalary.ToString("C2") + "\n");
            sb.Append("FICA Tax: " + ficaSalary.ToString("C2") + "\n");
            sb.Append("Federal Tax: " + federalSalary.ToString("C2") + "\n");
            sb.Append("" + "\n");

            sb.Append("Hourly Employee Weekly Summary:" + "\n");
            sb.Append("Gross Payroll: " + grossHourly.ToString("C2") + "\n");
            sb.Append("Net Payroll: " + netHourly.ToString("C2") + "\n");
            sb.Append("FICA Tax: " + ficaHourly.ToString("C2") + "\n");
            sb.Append("Federal Tax: " + federalHourly.ToString("C2") + "\n");
            sb.Append("" + "\n");

            sb.Append("Combined Weekly Summary:" + "\n");
            sb.Append("Gross Payroll: " + (grossHourly + grossSalary).ToString("C2") + "\n");
            sb.Append("Net Payroll: " + (netHourly + netSalary).ToString("C2") + "\n");
            sb.Append("FICA Tax: " + (ficaHourly + ficaSalary).ToString("C2") + "\n");
            sb.Append("Federal Tax: " + (federalHourly + federalSalary).ToString("C2") + "\n");
            sb.Append("" + "\n");

            return sb.ToString();
        }
    }
}
