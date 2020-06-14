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
    }
}