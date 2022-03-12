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
        [TestCase(2, 2, 4)]
        [TestCase(-3, -3, 9)]
        [TestCase(5, 3, 8)]
        [TestCase(0, -5, -5)]
        [TestCase(0, 5, -5)]
        [TestCase(-5, 1, -6)]
        [TestCase(1, 1, 1)]
        public void CooseOperationTest(int a, int b, int expected)
        {
            int actual = Condition.ChooseOperation(a, b);
            Assert.AreEqual(expected, actual);
        }

        //2,2
        [TestCase(0, 0, "Точка лежит на оси")]
        [TestCase(0, 2, "Точка лежит на оси")]
        [TestCase(2, 0, "Точка лежит на оси")]
        [TestCase(1, 1, "I четверть")]
        [TestCase(-1, 2, "II четверть")]
        [TestCase(-2, -3, "III четверть")]
        [TestCase(3, -5, "IV четверть")]
        public void DefineQuartTest(int x, int y, string expected)
        {
            string actual = Condition.DefineQuart(x, y);
            Assert.AreEqual(expected, actual);
        }

        //2.3
        [TestCase(1, 2, 3,new int[] {1,2,3})]
        [TestCase(1, 1, 3,new int[] {1,1,3})]
        [TestCase(3, 2, 1,new int[] {1,2,3})]
        [TestCase(1, 1, 1,new int[] {1,1,1})]
        [TestCase(1, 5, 3,new int[] {1,3,5})]
        [TestCase(-1, -2, -3,new int[] {-3,-2,-1})]
        public void SortTest(int a, int b, int c, int[] expected)
        {
            int[] actual = Condition.Sort(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //2.4
        [TestCase(2,3,1, new double[] {-0.5,-1})]
        [TestCase(3,2,1, new double[] { })]
        [TestCase(5,5,0, new double[] {0,-1})]
        [TestCase(4,12,-7, new double[] {0.5,-3.5})]
        [TestCase(3,0,-12, new double[] {2,-2})]
        [TestCase(3,0,-27, new double[] {3,-3})]
        [TestCase(1,6,9, new double[] {-3})]
        [TestCase(-8,6,14, new double[] {-1,1.75})]
        public void SolveQuadEquationTest(double a, double b, double c, double[] expected)
        {
            double[] actual = Condition.SolveQuadEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,6,14)]
        [TestCase(0,0,0)]
        [TestCase(0,6,0)]
        public void SolveQuadEquationTest_WhenAIsEqualZero_ShouldThroawArgumentExeption(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => Condition.SolveQuadEquation(a, b, c));
        }

        //2.5
        [TestCase(10,"Десять")]
        [TestCase(11,"Одиннадцать")]
        [TestCase(30,"Тридцать")]
        [TestCase(99,"Девяносто девять")]
        public void ConvertToInscriptionTest(int nomber, string expected)
        {
            string actual = Condition.ConvertToInscription(nomber);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(8)]
        [TestCase(-5)]
        [TestCase(120)]
        public void ConvertToInscriptionTest_WhanNomber_Less_Than_Ten_Or_More_Than_One_Hundred__ShouldThroawArgumentExeption(int nomber)
        {
            Assert.Throws<ArgumentException>(() => Condition.ConvertToInscription(nomber));
        }
    }
}
