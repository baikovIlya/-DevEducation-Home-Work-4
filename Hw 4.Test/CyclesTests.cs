using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Hw_4.Test
{
    public class CyclesTests
    {
        //3.1
        [TestCase(1, 1, 1)]
        [TestCase(2, 3, 8)]
        [TestCase(1, 3, 1)]
        [TestCase(3, 3, 27)]
        [TestCase(0, 1, 0)]
        [TestCase(0, 0, 1)]
        [TestCase(0, -1, 0)]
        [TestCase(4, -2, 0.0625)]
        public void ExponentiateTest(double a, double b, double expected)
        {
            double actual = Cycles.Exponentiate(a, b);
            Assert.AreEqual(expected, actual);
        }

        //3.2
        [TestCase(200, new int[] { 200, 400, 600, 800, 1000 })]
        [TestCase(600, new int[] { 600 })]
        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(300, new int[] { 300, 600, 900 })]
        [TestCase(-500, new int[] { 500, 1000 })]
        public void FindDivisibleNumbersTest(int a, int[] expected)
        {
            int[] actual = Cycles.FindDivisibleNumbers(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        public void FindDivisibleNumbersTest_WhenAIsEqualZero_ShouldThrowArgumentException(int a)
        {
            Assert.Throws<ArgumentException>(() => Cycles.FindDivisibleNumbers(a));
        }

        //3.3
        [TestCase(5, 2)]
        [TestCase(10, 3)]
        [TestCase(17, 4)]
        [TestCase(2, 1)]
        [TestCase(0, 0)]
        [TestCase(-5, 0)]
        public void GetSquearsTest(int nomber, int expected)
        {
            int actual = Cycles.GetSquears(nomber);
            Assert.AreEqual(expected, actual);
        }

        //3.4
        [TestCase(2, 1)]
        [TestCase(8, 4)]
        [TestCase(9, 3)]
        [TestCase(100, 50)]
        [TestCase(13, 1)]
        [TestCase(-20, 10)]
        public void SearchLargestDivisorTest(int nomber, int expected)
        {
            int actual = Cycles.SearchLargestDivisor(nomber);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        public void SearchLargestDivisorTest_WhenNomberIsEqualZero_ShouldThrowArgumentException(int nomber)
        {
            Assert.Throws<ArgumentException>(() => Cycles.SearchLargestDivisor(nomber));
        }

        //3.5
        [TestCase(6, 8, 7)]
        [TestCase(6, 15, 21)]
        [TestCase(6, 6, 0)]
        [TestCase(8, 13, 0)]
        [TestCase(13, 8, 0)]
        [TestCase(7, 7, 7)]
        [TestCase(-8, 7, 0)]
        [TestCase(0, 0, 0)]
        public void GetSevensTest(int a, int b, int expected)
        {
            int actual = Cycles.GetSevens(a, b);
            Assert.AreEqual(expected, actual);
        }

        //3.6
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        public void SearchFibonacciTest(int a, int expected)
        {
            int actual = Cycles.SearchFibonacci(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        [TestCase(-1)]
        public void SearchFibonacciTest_WhenAIsLessThenOne_ShouldThrowArgumentException(int a)
        {
            Assert.Throws<ArgumentException>(() => Cycles.SearchFibonacci(a));
        }

        //3.7
        [TestCase(1, 1, 1)]
        [TestCase(2, 4, 2)]
        [TestCase(12, 16, 4)]
        [TestCase(10, 25, 5)]
        [TestCase(-5, 10, 5)]
        public void SearchGCDTest(int a, int b, int expected)
        {
            int actual = Cycles.SearchGCD(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 0)]
        [TestCase(0, 1)]
        [TestCase(1, 0)]
        public void SearchGCDTest_WhearAOrBIsEqualZero_ShuoldThrowArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Cycles.SearchGCD(a, b));
        }

        //3.8
        [TestCase(0,0)]
        [TestCase(1,1)]
        [TestCase(-1,-1)]
        [TestCase(8,2)]
        [TestCase(125,5)]
        [TestCase(-27,-3)]
        public void SearchThirdRootTest(double nomber, double expected)
        {
            double actual = Cycles.SearchThirdRoot(nomber);
            Assert.AreEqual(expected, actual);
        }

        //3.9
        [TestCase(2, 0)]
        [TestCase(3, 1)]
        [TestCase(113, 3)]
        [TestCase(0, 0)]
        [TestCase(-3, 1)]
        [TestCase(55, 2)]
        public void SearchAmountOddTest(int nomber, int expected)
        {
            int actual = Cycles.SearchAmountOdd(nomber);
            Assert.AreEqual(expected, actual);
        }

        //3.10
        [TestCase(132, 231)]
        [TestCase(1000, 1)]
        [TestCase(-7895, -5987)]
        [TestCase(984, 489)]
        [TestCase(3, 3)]
        public void MirrorNomberTest(int nomber, int expected)
        {
            int actual = Cycles.MirrorNumber(nomber);
            Assert.AreEqual(expected, actual);
        }

        //3.11
        [TestCase(23, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22 })]
        [TestCase(3, new int[] { 2 })]
        [TestCase(1, new int[] { })]
        public void SearchEvenNumbers(int n, int[] expected)
        {
            int[] actual = Cycles.SearchEvenNumbers(n);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        [TestCase(-2)]
        public void SearchEvenNumbers(int n)
        {
            Assert.Throws<ArgumentException>(() => Cycles.SearchEvenNumbers(n));
        }

        //3.12
        [TestCase(1,21,true)]
        [TestCase(4,540,true)]
        [TestCase(0,0,true)]
        [TestCase(10,203,true)]
        [TestCase(20,510,true)]
        [TestCase(20,0,true)]
        [TestCase(214,103,true)]
        [TestCase(4,2,false)]
        [TestCase(0,2,false)]
        [TestCase(4,0,false)]
        public void SearchSameNombersTest(int a, int b, bool expected)
        {
            bool actual = Cycles.SearchSameNombers(a, b);
            Assert.AreEqual(expected, actual);
        }

    }
}
