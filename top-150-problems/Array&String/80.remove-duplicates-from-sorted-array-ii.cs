/*
 * @lc app=leetcode id=80 lang=csharp
 *
 * [80] Remove Duplicates from Sorted Array II
 */

// @lc code=start
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        // int k = 1;
        // Dictionary<int, int> occurence = new Dictionary<int, int>();

        // occurence.Add(nums[0], 1);

        // for (int i = 1; i < nums.Length; i++)
        // {
        //     if (nums[i] == nums[i - 1] && occurence[nums[i]] < 2)
        //     {
        //         nums[k++] = nums[i];
        //         occurence[nums[i]] += 1;
        //     }
        //     else if (nums[i] != nums[i - 1])
        //     {
        //         nums[k++] = nums[i];
        //         occurence.Add(nums[i], 1);
        //     }
        // }

        // return k;
        if (nums.Length <= 2) return nums.Length;
        int k = 2;

        for (int i = 2; i < nums.Length; i++)
        {
            //so với những phần tử hợp lệ cuối cùng => ko cần biến phụ đếm lại
            //an toàn hơn là xài i
            //tổng quát là dạng nums[i] != nums[k-m]
            if (nums[i] != nums[k - 2])
            {
                nums[k++] = nums[i];
            }
        }

        return k;
    }
}
// @lc code=end

