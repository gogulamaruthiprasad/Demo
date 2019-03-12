using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using CalculatorDemo;

namespace CalculatorDemoTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Adding_4_And_3_Should_Return_7()
        {
            var calculator = new Calculator();

            int result = calculator.Add(4, 3);

            Assert.AreEqual(7, result);
        }
        [TestMethod]
        public void Substract_4_And_3_Should_Return_1()
        {
            var calculator = new Calculator();

            int result = calculator.Substract(4, 3);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Multiply_4_And_3_Should_Return_12()
        {
            var calculator = new Calculator();

            int result = calculator.Multiply(4, 3);

            Assert.AreEqual(12, result);
        }
        [TestMethod]
        public void divide_20_And_4_Should_Return_5()
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            int result = calculator.divide(20, 4);
            //Assert
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void validateFullName()
        {
            //Arrange
            string fname = "Maruthi";
            string mname = "Prasad";
            string lname = "Gogula";

            var calculator = new Calculator();
            //Act
            string result = calculator.getFullName(fname, mname, lname);
            //Assert

            result.Should().StartWith("Ma");
            result.Should().NotStartWith("Pr");
            result.Should().NotStartWith("Go");
            result.Should().StartWithEquivalent("Maruthi Prasad Gogula");
            result.Should().EndWith("la");
            result.Should().NotBeNull();
            result.Should().NotBeEmpty("because the result is not empty");
            result.Should().HaveLength(21);
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().StartWith("Ma").And.EndWith("la").And.Contain("Prasad").And.HaveLength(21);

        }
    }
}
