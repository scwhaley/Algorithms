using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary.Tests
{
    [TestClass()]
    public class LeetCodeTests
    {
        [TestMethod()]
        public void TwoSumTestWithValidInputs()
        {
            int[] integerArray = new int[] { 2, 7, 1, 15 };
            int targetSum = 9;

            int[] indices = new int[2];
            try
            {
                indices = LeetCode.TwoSum(integerArray, targetSum);
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }

            Assert.AreEqual(integerArray[indices[0]] + integerArray[indices[1]], targetSum);
        }

        [TestMethod()]
        public void TwoSumTestWithBadInputs()
        {
            int[] integerArray = new int[] { 2, 10, 1, 15 };
            int targetSum = 9;

            int[] indices = new int[2];
            bool caughtExceptionBool = false;
            try
            {
                indices = LeetCode.TwoSum(integerArray, targetSum);
            }
            catch (Exception)
            {
                caughtExceptionBool = true;
            }

            Assert.IsTrue(caughtExceptionBool);
        }

        [TestMethod()]
        public void ReversePostitiveIntegerTest()
        {
            int startInt = 342;
            int reversedInt = LeetCode.ReverseInteger(startInt);
            Assert.AreEqual(243, reversedInt);
        }

        [TestMethod()]
        public void ReverseNegativeIntegerTest()
        {
            int startInt = -342;
            int reversedInt = LeetCode.ReverseInteger(startInt);
            Assert.AreEqual(-243, reversedInt);
        }

        // This test should cause overflow
        [DataTestMethod()]
        [DataRow(int.MinValue)]
        [DataRow(int.MaxValue)]
        public void ReverseNegativeIntMinTest(int startInt)
        {
            int reversedInt = LeetCode.ReverseInteger(startInt);
            Assert.AreEqual(0, reversedInt);
        }

        [DataTestMethod()]
        [DataRow(12321, true)]
        [DataRow(12345, false)]
        public void IntIsPalindromTest(int startInt, bool expectedIsPalindrome)
        {
            bool testIsPalindrome = LeetCode.IntIsPalindrome(startInt);
            Assert.AreEqual(expectedIsPalindrome, testIsPalindrome);
        }
    }
}
