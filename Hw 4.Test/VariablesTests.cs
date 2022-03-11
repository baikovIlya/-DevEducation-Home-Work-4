using NUnit.Framework;
using System;
using Hw_4;

namespace Hw_4.Test
{
    public class VariablesTests
    {
     
        [TestCase]
        public void DivAndResTest()
        {
            Assert.Pass();
        }

        [TestCase(2,3,19)]
        [TestCase(4,8,21)]
        [TestCase(-7,-5,-5)]
        public void EquationTest(int a,int b, double expected)
        {
            double actual = Variables.Equation(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}