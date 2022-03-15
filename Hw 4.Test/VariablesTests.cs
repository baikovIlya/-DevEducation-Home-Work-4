using NUnit.Framework;
using System;
using Hw_4;

namespace Hw_4.Test
{
    public class VariablesTests
    {
        //1.1
        [TestCase(2,2,1,0)]
        [TestCase(5,2,2,1)]
        [TestCase(9,1,9,0)]
        [TestCase(10,3,3,1)]
        [TestCase(-20,-7,2,-6)]
        [TestCase(-8,-4,2,0)]
        [TestCase(0,2,0,0)]
        public void DivAndResTest(int a, int b, int expectedDiv, int expectedRes)
        {
            int actual1;
            int actual2;
            Variables.DivAndRes(a, b, out actual1, out actual2);
            Assert.AreEqual(expectedDiv, actual1);
            Assert.AreEqual(expectedRes, actual2);
        }

        [TestCase(-8,0)]
        [TestCase(0,0)]
        [TestCase(2,0)]
        public void DivAndResTest_WhenBIsEqualZero_ShouldThrowArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Variables.DivAndRes(a,b, out int rez1, out int rez2));
        }

        //1.2
        [TestCase(2,3,19)]
        [TestCase(4,8,21)]
        [TestCase(-7,-5,-5)]
        public void SolveTheEquationTest(int a,int b, double expected)
        {
            double actual = Variables.SolveTheEquation(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,0)]
        [TestCase(2,2)]
        [TestCase(-5,-5)]
        public void SolveTheEquationTest_WhenAIsEqualB_ShouldThrowExeption(int a,int b)
        {
            Assert.Throws<Exception>(() => Variables.SolveTheEquation(a, b));
        }

        //1.3
        [TestCase(12,23,23,12)]
        [TestCase(11,11,11,11)]
        [TestCase(50,20,20,50)]
        [TestCase(-50,20,20,-50)]
        public void SwapTest(int a, int b, int expectedA, int expectedB)
        {
            Variables.Swap(ref a, ref b);
            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
        }

        //1.4
        [TestCase(3,2,2,0)]
        [TestCase(4,5,8,0.75)]
        [TestCase(-5,2,10,-1.6)]
        [TestCase(6,4,10,1)]
        public void SearchXTest(int a, int b, int c, double expected)
        {
            double actual = Variables.SearchX(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(0,2,10)]
        [TestCase(0,3,8)]
        [TestCase(0,5,11)]
        public void SearchXTest_WhenAIsEqualZero_ShouldThrowExeption(int a, int b, int c)
        {
            Assert.Throws<Exception>(() => Variables.SearchX(a, b, c));
        }

        //1.5
        [TestCase(2,2,4,4,"Y=1X+0")]
        [TestCase(3,4,2,5,"Y=-1X+7")]
        [TestCase(-5,6,3,4,"Y=-0,25X+4,75")]
        [TestCase(0,2,1,5,"Y=3X+2")]
        [TestCase(10,15,8,7,"Y=4X+-25")]
        public void GetEquationTest(double x1, double y1, double x2, double y2, string expected)
        {
            string actual = Variables.GetEquation(x1, y1, x2, y2);
            Assert.AreEqual(expected,actual);
        }
        
        [TestCase(10,5,10,7)]
        [TestCase(0,0,0,0)]
        [TestCase(1,-5,1,8)]
        public void GetEquationTest_WhenX1IsEqualX2_ShouldThroawArgumentExeption(double x1, double y1, double x2, double y2)
        {
            Assert.Throws<ArgumentException>(() => Variables.GetEquation(x1, y1, x2, y2));
        }

    }
}