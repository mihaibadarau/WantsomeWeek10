using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    class ut_Calculator
    {
        [TestCase(8, 5, 13)]
        [TestCase(19, 3, 22)]
        [TestCase(15.5, 5, 20.5)]
        [TestCase(16.2, 10, 26.2)]
        public void TestAdd(double a, double b, double expected)
        {
            Assert.AreEqual(expected, Calculator.Add(a, b));
        }

        [TestCase(8, 5, 3)]
        [TestCase(19, 3, 16)]
        [TestCase(15.5, 5, 10.5)]
        [TestCase(16.2, 10, 6.1999999999999993)]
        public void TestSub(double a, double b, double expected)
        {
            Assert.AreEqual(expected, Calculator.Sub(a, b));
        }

        [TestCase(8, 5, 40)]
        [TestCase(19, 3, 57)]
        [TestCase(15.5, 5, 77.5)]
        [TestCase(16.2, 10, 162)]
        public void TestMul(double a, double b, double expected)
        {
            Assert.AreEqual(expected, Calculator.Mul(a, b));
        }

        [TestCase(8, 5, 1.6)]
        [TestCase(19, 3, 6.333333333333333)]
        [TestCase(15.5, 5, 3.1)]
        [TestCase(16.2, 10, 1.6199999999999999)]
        public void TestDiv(double a, double b, double expected)
        {
            Assert.AreEqual(expected, Calculator.Div(a, b));
        }
    }
}
