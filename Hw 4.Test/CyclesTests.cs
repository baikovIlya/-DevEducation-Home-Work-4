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
        [TestCase(1,1,1)]
        [TestCase(2,3,8)]
        [TestCase(1,3,1)]
        [TestCase(3,3,27)]
        [TestCase(0,1,0)]
        [TestCase(0,0,1)]
        [TestCase(0,-1,0)]
        [TestCase(4,-2,0.0625)]
        public void ExponentiateTest(double a, double b, double expected)
        {
            double actual = Cycles.Exponentiate(a, b);
            Assert.AreEqual(expected, actual);
        }

        //3.2
        [TestCase(200,new int[] {200,400,600,800,1000})]
        [TestCase(600,new int[] {600})]
        [TestCase(500,new int[] {500,1000})]
        [TestCase(300,new int[] {300,600,900})]
        [TestCase(-500,new int[] {500,1000})]
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
        [TestCase(5,2)]
        [TestCase(10,3)]
        [TestCase(17,4)]
        [TestCase(2,1)]
        [TestCase(0,0)]
        [TestCase(-5,0)]
        public void GetSquearsTest(int nomber, int expected)
        {
            int actual = Cycles.GetSquears(nomber);
            Assert.AreEqual(expected, actual);
        }

        //3.4
        [TestCase(2,1)]
        [TestCase(8,4)]
        [TestCase(9,3)]
        [TestCase(100,50)]
        [TestCase(13,1)]
        [TestCase(-20,10)]
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
        [TestCase(6,8,7)]
        [TestCase(6,15,21)]
        [TestCase(6,6,0)]
        [TestCase(8,13,0)]
        [TestCase(13,8,0)]
        [TestCase(7,7,7)]
        [TestCase(-8,7,0)]
        [TestCase(0,0,0)]
        public void GetSevensTest(int a, int b, int expected)
        {
            int actual = Cycles.GetSevens(a,b);
            Assert.AreEqual(expected, actual);
        }

    }
}
