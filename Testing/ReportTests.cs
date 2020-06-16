using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class ReportTests
    {
        [TestMethod]
        public void TestReport()
        {
            List<Employee> list = new List<Employee>();
            var hourly = new HourlyEmployee(20, 100, "test", "one", 24m, 40m);
            var salary = new SalariedEmployee(20, 101, "test", "two", 1000m);
            list.Add(hourly);
            list.Add(salary);
            var isString = Report.RunReport(list);
            bool result = isString is string;
            Assert.IsTrue(result);
        }
    }
}
