using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Hw_4.Test
{
    public class TwoDimArryCtrlTests
    {
        //5.1
        [TestCase(TDAMockType.One,1)]
        [TestCase(TDAMockType.Quadtwo,10)]
        [TestCase(TDAMockType.Quadthree,12)]
        [TestCase(TDAMockType.Quadfour,-4)]
        [TestCase(TDAMockType.ThreeByFour,0)]
        public void SearchMinTest(TDAMockType type, int expected)
        {
            int[,] ar = TDAMock.GetMock(type);
            int actual = TwoDimArrayCtrl.SearchMin(ar);
            Assert.AreEqual(expected, actual);
        }

        //5.2
        [TestCase(TDAMockType.One, 1)]
        [TestCase(TDAMockType.Quadtwo, 33)]
        [TestCase(TDAMockType.Quadthree, 78)]
        [TestCase(TDAMockType.Quadfour, 99)]
        [TestCase(TDAMockType.ThreeByFour, 90)]
        public void SearchMaxTest(TDAMockType type, int expected)
        {
            int[,] ar = TDAMock.GetMock(type);
            int actual = TwoDimArrayCtrl.SearchMax(ar);
            Assert.AreEqual(expected, actual);
        }

        //5.3
        [TestCase(TDAMockType.One, new int[] {0,0})]
        [TestCase(TDAMockType.Quadtwo, new int[] { 0, 0 })]
        [TestCase(TDAMockType.Quadthree, new int[] { 2, 1 })]
        [TestCase(TDAMockType.Quadfour, new int[] { 3, 3 })]
        [TestCase(TDAMockType.ThreeByFour, new int[] { 2, 0 })]
        public void SearchindexOfMinTest(TDAMockType type, int[] expected)
        {
            int[,] ar = TDAMock.GetMock(type);
            int[] actual = TwoDimArrayCtrl.SearchIndexOfMin(ar);
            Assert.AreEqual(expected, actual);
        }

        //5.4
        [TestCase(TDAMockType.One, new int[] { 0, 0 })]
        [TestCase(TDAMockType.Quadtwo, new int[] { 1,1 })]
        [TestCase(TDAMockType.Quadthree, new int[] { 2, 0 })]
        [TestCase(TDAMockType.Quadfour, new int[] { 3, 0 })]
        [TestCase(TDAMockType.ThreeByFour, new int[] { 1, 3 })]
        public void SearchindexOfMaXTest(TDAMockType type, int[] expected)
        {
            int[,] ar = TDAMock.GetMock(type);
            int[] actual = TwoDimArrayCtrl.SearchIndexOfMax(ar);
            Assert.AreEqual(expected, actual);
        }
    }
}
