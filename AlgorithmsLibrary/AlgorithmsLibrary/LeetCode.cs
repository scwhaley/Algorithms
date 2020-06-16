using System;
using System.Security.Cryptography;

namespace AlgorithmsLibrary
{
    public class LeetCode
    {
        // Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        public static int[] TwoSum(int[] integerArray, int desiredSum)
        {
            for (int i = 0; i < integerArray.Length-1; i++)
            {
                for (int e = i+1; e < integerArray.Length; e++)
                {
                    if (integerArray[i]+integerArray[e] == desiredSum)
                    {
                        int[] targetIndices = { i, e};
                        return  targetIndices;
                    }
                }
            }

            throw new ArgumentException("The supplied integer array does not have 2 integers that add to the desired sum");
        }
    }
}
