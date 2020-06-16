using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;
using System;

namespace Testing
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestMenu()
        {
            var isString = Program.Menu();
            bool result = isString is string;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestAlphabeticAllChar()
        {
            string value = "test";
            var result = Program.LettersOnly(value);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestAlphabeticNotAllChar()
        {
            string value = "test123";
            var result = Program.LettersOnly(value);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestAlphabeticEmpty()
        {
            string value = "";
            var result = Program.LettersOnly(value);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestIntConvert()
        {
            string value = "123";
            var isInt = Program.IntConvert(value);
            bool result = isInt is int;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestDecimalConvert()
        {
            string value = "123";
            var isDecimal = Program.DecimalConvert(value);
            bool result = isDecimal is decimal;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestDecimalConvert2()
        {
            string value = "wafwa21f/21p[]";
            bool result = value is decimal;
            Assert.IsFalse(result);
        }
    }
}
