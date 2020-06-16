using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;
namespace Testing
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void TestEmployeeName()
        {
            int age = 20;
            int employeeID = 100;
            string firstName = "test";
            string lastName = "user";
            decimal monthlyPay = 1000m;
            var emp = new SalariedEmployee(age, employeeID, firstName, lastName, monthlyPay);
            bool result = emp.Name is string;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestEmployeeAge()
        {
            int age = 20;
            int employeeID = 100;
            string firstName = "test";
            string lastName = "user";
            decimal monthlyPay = 1000m;
            var emp = new SalariedEmployee(age, employeeID, firstName, lastName, monthlyPay);
            bool result = emp.Age is int;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestEmployeeConstructor()
        {
            int age = 20;
            int employeeID = 100;
            string firstName = "test";
            string lastName = "user";
            decimal monthlyPay = 1000m;
            var emp = new SalariedEmployee(age, employeeID, firstName, lastName, monthlyPay);
            bool result = emp is Employee;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestEmployeeID()
        {
            int age = 20;
            int employeeID = 100;
            string firstName = "test";
            string lastName = "user";
            decimal monthlyPay = 1000m;
            var emp = new SalariedEmployee(age, employeeID, firstName, lastName, monthlyPay);
            bool result = emp.EmployeeID is int;
            Assert.IsTrue(result);
        }
    }
}
