using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            string choice = "l";
            while (choice != "4")
            {
                string choices = Menu();
                Console.WriteLine(choices);
                choice = Console.ReadLine();
                Console.WriteLine("");
                switch (choice)
                {
                    case "1":
                        Employee salary = CreateSalaried();
                        employee.Add(salary);
                        break;
                    case "2":
                        Employee hourly = CreateHourly();
                        employee.Add(hourly);
                        break;
                    case "3":
                        Console.WriteLine(Report.RunReport(employee));
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }

        public static string Menu()
        {
            string one = "1: Add A Salaried Employee\n";
            string two = "2: Add An Hourly Employee\n";
            string three = "3: Run The Report\n";
            string four = "4: Quit";
            StringBuilder sb = new StringBuilder(one);
            sb.Append(two);
            sb.Append(three);
            sb.Append(four);
            return sb.ToString();
        }

        public static bool LettersOnly(string value)
        {
            if (value == "" || value == null)
            {
                return false;
            }
            foreach (char a in value)
            {
                if (!char.IsLetter(a))
                    return false;
            }
            return true;
        }
        public static int IntConvert(string i)
        {
            int n;
            while (!int.TryParse(i, out n))
            {
                Console.WriteLine("Invalid Number.");
                i = Console.ReadLine();
            }
            return n;
        }
        public static decimal DecimalConvert(string i)
        {
            decimal n;
            while (!decimal.TryParse(i, out n))
            {
                Console.WriteLine("Invalid Number.");
                i = Console.ReadLine();
            }
            return n;
        }

        public static SalariedEmployee CreateSalaried()
        {
            string firstName;
            string lastName;
            string age;
            string ID; 
            string monthlyPay;
            int ageConvert;
            int IDConvert;
            decimal monthlyPayConvert;

            Console.WriteLine("Enter employee's first name.");
            firstName = Console.ReadLine();

            while (!LettersOnly(firstName))
            {
                Console.WriteLine("Invalid first name.");
                firstName = Console.ReadLine();
            }

            Console.WriteLine("Enter employee's last name.");
            lastName = Console.ReadLine();

            while (!LettersOnly(lastName))
            {
                Console.WriteLine("Invalid last name.");
                lastName = Console.ReadLine();
            }

            Console.WriteLine("Enter employee's age.");
            age = Console.ReadLine();
            ageConvert = IntConvert(age);

            Console.WriteLine("Enter employee's ID number.");
            ID = Console.ReadLine();
            IDConvert = IntConvert(ID);

            Console.WriteLine("Enter employee's monthly pay.");
            monthlyPay = Console.ReadLine();
            monthlyPayConvert = DecimalConvert(monthlyPay);

            SalariedEmployee salaryEmp = new SalariedEmployee(ageConvert, IDConvert, firstName, lastName, monthlyPayConvert);
            return salaryEmp;
        }
        public static HourlyEmployee CreateHourly()
        {
            string firstName;
            string lastName;
            string age;
            string ID;
            string hourlyPay;
            string hoursWorked;
            int ageConvert;
            int IDConvert;
            decimal hourlyPayConvert;
            decimal hoursWorkedConvert;

            Console.WriteLine("Enter employee's first name.");
            firstName = Console.ReadLine();

            while (!LettersOnly(firstName))
            {
                Console.WriteLine("Invalid first name.");
                firstName = Console.ReadLine();
            }

            Console.WriteLine("Enter employee's last name.");
            lastName = Console.ReadLine();

            while (!LettersOnly(lastName))
            {
                Console.WriteLine("Invalid last name.");
                lastName = Console.ReadLine();
            }

            Console.WriteLine("Enter employee's age.");
            age = Console.ReadLine();
            ageConvert = IntConvert(age);

            Console.WriteLine("Enter employee's ID number.");
            ID = Console.ReadLine();
            IDConvert = IntConvert(ID);

            Console.WriteLine("Enter employee's hourly pay.");
            hourlyPay = Console.ReadLine();
            hourlyPayConvert = DecimalConvert(hourlyPay);

            Console.WriteLine("Enter employee's hours worked.");
            hoursWorked = Console.ReadLine();
            hoursWorkedConvert = DecimalConvert(hoursWorked);

            HourlyEmployee hourlyEmp = new HourlyEmployee(ageConvert, IDConvert, firstName, lastName, hourlyPayConvert, hoursWorkedConvert);
            return hourlyEmp;
        }
    }
}