using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Hw_4.Test
{
    public class ArrayControlTests
    {
        //4.1
        [TestCase(new int[3] {0,1,4},0)]
        [TestCase(new int[2] {4,1},1)]
        [TestCase(new int[1] {4},4)]
        [TestCase(new int[3] {-5,1,4},-5)]
        [TestCase(new int[3] {11,11,11},11)]
        public void SearchMinTest(int[] ar, int expected)
        {
            int actual = ArrayControl.SearchMin(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {})]
        public void SearchMinTest_WhenArrayIsEmpty_ShouldThrowArgumentException(int[] ar)
        {
            Assert.Throws<ArgumentException>(() => ArrayControl.SearchMin(ar));
        }

        //4.2
        [TestCase(new int[3] {0,2,5 }, 5)]
        [TestCase(new int[2] {-5,8 }, 8)]
        [TestCase(new int[1] {9}, 9)]
        [TestCase(new int[3] {5,5,5}, 5)]
        [TestCase(new int[3] {9,11,-12 }, 11)]
        public void SearchMaxTest(int[] ar, int expected)
        {
            int actual = ArrayControl.SearchMax(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void SearchMaxTest_WhenArrayIsEmpty_ShouldThrowArgumentException(int[] ar)
        {
            Assert.Throws<ArgumentException>(() => ArrayControl.SearchMin(ar));
        }

        //4.3
        [TestCase(new int[3] {1,4,8 }, 0)]
        [TestCase(new int[1] {8 }, 0)]
        [TestCase(new int[3] {6,0,84 }, 1)]
        [TestCase(new int[3] {1,4,-8 }, 2)]
        public void GetIndexOfMinTest(int[] ar, int expected)
        {
            int actual = ArrayControl.GetIndexOfMin(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetIndexOfMinTest_WhenArrayIsEmpty_ShouldThrowArgumentException(int[] ar)
        {
            Assert.Throws<ArgumentException>(() => ArrayControl.GetIndexOfMin(ar));
        }

        //4.4
        [TestCase(new int[3] { 1, 8, 4 }, 1)]
        [TestCase(new int[1] { 8 }, 0)]
        [TestCase(new int[3] { 11, 8, 4 }, 0)]
        [TestCase(new int[3] { 1, 8, 44 }, 2)]
        public void GetIndexOfMaxTest(int[] ar, int expected)
        {
            int actual = ArrayControl.GetIndexOfMax(ar);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetIndexOfMaxTest_WhenArrayIsEmpty_ShouldThrowArgumentException(int[] ar)
        {
            Assert.Throws<ArgumentException>(() => ArrayControl.GetIndexOfMax(ar));
        }

        //4.5
        [TestCase(new int[4] {1,1,3,5 },6)]
        [TestCase(new int[2] {6,7 },7)]
        [TestCase(new int[1] { 4},0)]
        [TestCase(new int[] { },0)]
        [TestCase(new int[3] {2,5,6 },5)]
        [TestCase(new int[4] {1,0,2,0 },0)]
        [TestCase(new int[4] {1,8,2,9 },17)]
        [TestCase(new int[4] {1,5,2,5 },10)]
        public void GetSummOfOddIndexTest(int[] ar, int expected)
        {
            int actual = ArrayControl.GetSummOfOddIndex(ar);
            Assert.AreEqual(expected, actual);
        }

        //4.7
        [TestCase(new int[4] { 1, 1, 3, 5 }, 4)]
        [TestCase(new int[2] { 6, 7 }, 1)]
        [TestCase(new int[1] { 4 }, 0)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[3] { 2, 5, 6 }, 1)]
        [TestCase(new int[4] { 1, 0, 2, 0 }, 1)]
        public void GetSummOfOddTest(int[] ar, int expected)
        {
            int actual = ArrayControl.GetSummOfOdd(ar);
            Assert.AreEqual(expected, actual);
        }
        
        //4.8
        [TestCase(new int[] { },new int[] { })]
        [TestCase(new int[1] {1 },new int[1] {1 })]
        [TestCase(new int[2] {1,2 },new int[2] { 2,1})]
        [TestCase(new int[3] {11,45,23 },new int[3] {23,45,11 })]
        [TestCase(new int[5] {10,20,30,40,50 },new int[5] {40,50,30,10,20 })]
        public void ReverseOfHalfTest(int[]ar, int[] expected)
        {
            int[] actual = ArrayControl.ReverseOfHalf(ar);
            Assert.AreEqual(expected, actual);
        }

    }
}
