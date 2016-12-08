using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorServiceTests
    {
        [TestMethod]
        public void Add_Given2Plus2_ResultsIn4()
        {
            var calculator = new CalculatorService();

            var result = calculator.Add(2, 2);

            result.Should().Be(4);
        }

        [TestMethod]
        public void Add_Given5PlusMinus2_ResultsIn3()
        {
            var calculator = new CalculatorService();

            var result = calculator.Add(5, -2);

            result.Should().Be(3);
        }

        [TestMethod]
        public void Divide_Given6Over2_ResultsIn3()
        {
            var calculator = new CalculatorService();

            var result = calculator.Divide(6, 2);

            result.Should().Be(3);
        }

        [TestMethod]
        public void Divide_Given5OverMinus5_ResultsInMinusOne()
        {
            var calculator = new CalculatorService();

            var result = calculator.Divide(5, -5);

            result.Should().Be(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(MathException))]
        public void Divide_GivenZeroDenominator_ThrowsMathException()
        {
            var calculator = new CalculatorService();

            var result = calculator.Divide(5, 0);

            //assertion via ExpectedException
        }
    }
}
