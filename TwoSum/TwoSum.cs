using System;
using System.Collections;
using System.Collections.Generic;

namespace Leetcode75;

public static class TwoSum
{
    public static int[] FindIndicies(int[] nums, int target)
    {

        IDictionary<int, int> SumHash = new Dictionary<int, int>();
        // Hashtable SumHash = new Hashtable();

        for (int i = 0; i < nums.Length; i++)
        {
            int item = nums[i];
            if (!SumHash.ContainsKey(target-item)){
                if(!SumHash.ContainsKey(item)){
                    SumHash.Add(item, i);
                }
            }
            else{
                int [] result = { (int)SumHash[target-item], i};
                return result;
            }
        }

        // foreach (KeyValuePair<int, int> item in SumHash)
        // {
        //     Console.Write(item.Key+" : " + item.Value.ToString() +" , ");               
        // }   
        int [] wrong = {-1, -1};
        return wrong;
    }

    public static void Main(){
        Console.WriteLine("I ran!");
    }
}
        /*

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

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

 

Constraints:

    2 <= nums.length <= 104
    -109 <= nums[i] <= 109
    -109 <= target <= 109
    Only one valid answer exists.

 
Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?

        */