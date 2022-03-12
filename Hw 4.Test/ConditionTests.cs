using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Hw_4.Test
{
    public class ConditionTests
    {
        //2.1
        [TestCase(2,2,4)]
        [TestCase(-3,-3,9)]
        [TestCase(5,3,8)]
        [TestCase(0,-5,-5)]
        [TestCase(0,5,-5)]
        [TestCase(-5,1,-6)]
        [TestCase(1,1,1)]
        public void CooseOperationTest(int a, int b, int expected)
        {
            int actual = Condition.ChooseOperation(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,0,"Точка лежит на оси")]
        [TestCase(0,2,"Точка лежит на оси")]
        [TestCase(2,0,"Точка лежит на оси")]
        [TestCase(1,1,"I четверть")]
        [TestCase(-1,2,"II четверть")]
        [TestCase(-2,-3,"III четверть")]
        [TestCase(3,-5,"IV четверть")]
        public void DefineQuartTest(int x, int y, string expected)
        {
            string actual = Condition.DefineQuart(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
