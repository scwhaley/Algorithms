using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace AlgorithmsLibrary
{
    public class LeetCode
    {

        
        // Problem 1
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

        // Problem 7
        // Given a 32-bit signed integer, reverse digits of an integer.
        public static int ReverseInteger(int startInt)
        {
            int reversedInt = 0;

            while (startInt != 0)
            {
                try
                {
                    // C# does not check for overflow/underflow exceptions by default. Alternatively could check for sign change of answer due to signed bit changing.
                    checked { reversedInt = reversedInt * 10 + (startInt % 10); }
                }
                catch (OverflowException)
                {
                    return 0;
                }

                startInt /= 10;
            }

            return reversedInt;
        }

        // Problem 9
        //Determine whether an integer is a palindrome.An integer is a palindrome when it reads the same backward as forward.
        public static bool IntIsPalindrome(int testInt)
        {
            int reversedInt = ReverseInteger(testInt);

            if (testInt == reversedInt)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Problem 14
        // Write a function to find the longest common prefix string amongst an array of strings.
        // If there is no common prefix, return an empty string "".
        public static string LongestCommonStringPrefix(List<string> stringList)
        {
            string prefix;
            string lastPrefix = "";

            for (int prefixLength = 1; prefixLength <= stringList[0].Length; prefixLength++)
            {
                prefix = stringList[0].Substring(0, prefixLength);

                for (int e = 1; e < stringList.Count; e++)
                {
                    if (!stringList[e].StartsWith(prefix))
                    {
                        return lastPrefix;
                    }
                }
                lastPrefix = prefix;
            }

            // if you get here, then the entire string matched
            return lastPrefix;
        }

        // Problem 21 - Extended
        public static List<int> MergeLists(List<List<int>> listOfSortedLists)
        {
            List<int> mergedList = listOfSortedLists[0];
            mergedList.Sort();

            for (int i = 1; i < listOfSortedLists.Count; i++)
            {
                for (int e = 0; e < listOfSortedLists[i].Count; e++)
                {
                    for (int k = 0; k < mergedList.Count; k++)
                    {
                        // 2 conditions. Starting at the least sorted value, if unsorted value is less than the sorted value,
                        // then insert before the sorted value.
                        // If the unsorted value was bigger than all the sorted values, then append to end.
                        if (listOfSortedLists[i][e]<= mergedList[k])
                        {
                            mergedList.Insert(k, listOfSortedLists[i][e]);
                            break;
                        }

                        if (k==mergedList.Count-1)
                        {
                            mergedList.Add(listOfSortedLists[i][e]);
                            break;
                        }
                    }
                }
            }

            foreach (var item in mergedList)
            {
                File.AppendAllText(@"C:\Temp\Debug.txt", $"{item}");
            }
            return mergedList;
        }
    }
}
