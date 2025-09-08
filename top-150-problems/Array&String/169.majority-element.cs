/*
 * @lc app=leetcode id=169 lang=csharp
 *
 * [169] Majority Element
 */

// @lc code=start
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        // decimal majority = (decimal)(nums.Length) / (decimal)2;

        // Dictionary<int, int> majorityMap = new Dictionary<int, int>();

        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (!majorityMap.TryGetValue(nums[i], out var value))
        //         majorityMap.Add(nums[i], 1);
        //     else
        //         majorityMap[nums[i]]++;

        //     if (majorityMap[nums[i]] >= majority)
        //         return nums[i];
        // }
        // return 0;

        int candidate = 0;
        int count = 0;
        //Vì majority > n/2 => nó lớn hơn tổng số lần xuất hiện của các
        //phần tử khác cộng lại
        foreach (var item in nums)
        {
            if (count == 0)
            {
                candidate = item;
                count = 1;
            }

            else if (candidate == item)
            {
                count++;
            }

            else
            {
                count--;
            }
        }

        return candidate;
    }
}
// @lc code=end

