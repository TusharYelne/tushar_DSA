using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LeetCode
{
    /* Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

     You may assume that each input would have exactly one solution, and you may not use the same element twice.

     You can return the answer in any order.

     Example 1:

 Input: nums = [2, 7, 11, 15], target = 9
 Output: [0,1]
 Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
 Example 2:

 Input: nums = [3, 2, 4], target = 6
 Output: [1,2]
 Example 3:

 Input: nums = [3, 3], target = 6
 Output: [0,1]


 Constraints:

 2 <= nums.length <= 104
 -109 <= nums[i] <= 109
 -109 <= target <= 109
 Only one valid answer exists.


 Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?*/
    class TwoSumCal
    {

        public int[] TwoSum(int[] nums, int target)
        {
            var arrayLenght = nums.Length;

            for (int i = 0; i < arrayLenght; i++)
            {
                Dictionary<int, int> resultDictionary = new Dictionary<int, int>();
                var firstNumber = nums[i];
                var secondNumber = target - firstNumber;
                if (resultDictionary.TryGetValue(secondNumber, out int index))
                {
                    return new int[] { index, i };

                }
                resultDictionary[firstNumber] = i;
            }

            return Array.Empty<int>();
        }
    }
}
//Success
//Details
//Runtime: 153 ms, faster than 96.42% of C# online submissions for Two Sum.
//Memory Usage: 43 MB, less than 49.68% of C# online submissions for Two Sum.