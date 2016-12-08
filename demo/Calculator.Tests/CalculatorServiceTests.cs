using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorServiceTests
    {
        [TestMethod]
        public void Add_With2And2_ShouldReturn4()
        {
            var subject = new CalculatorService();

            var result = subject.Add(2, 2);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Add_With6AndMinus3_ShouldReturn3()
        {
            var subject = new CalculatorService();

            var result = subject.Add(6, -3);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Divide_With4And2_ShouldReturn2()
        {
            var subject = new CalculatorService();

            var result = subject.Divide(4, 2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(MathException))]
        public void Divide_With4And0_ShouldThrowException()
        {
            var subject = new CalculatorService();

            var result = subject.Divide(4, 0);

            //assertion via ExpectedException
        }
    }
}
