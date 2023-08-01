using System;
using Xunit;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetcode75;

namespace Leetcode75Test;

// [TestClass]
public class TwoSumTest
{
    // Arrange
    [Theory]
    [InlineData( 9, 0, 1, 2, 7, 11, 15 )]
    [InlineData( 11, 5, 11, 1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1 )]
    public void TestFindIndices(int target, int firstIndex, int secondIndex, params int [] nums)
    {

        //Act
        int[] result = TwoSum.FindIndicies(nums, target);
        bool correct = result[0]==firstIndex && result[1] == secondIndex;

        //Assert
        Assert.True(correct,
               string.Format("Expected: [ {0} , {1} ], Actual: [ {2} , {3} ]",
                             firstIndex, secondIndex, result[0], result[1]));
    }
}

/*
Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
*/