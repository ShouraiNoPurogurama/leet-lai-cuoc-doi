/*
 * @lc app=leetcode id=45 lang=csharp
 *
 * [45] Jump Game II
 */

// @lc code=start
public class Solution
{
    public int Jump(int[] nums)
    {
        // //so sánh combination tốt nhất có thể tìm được trong số bước có thể đi
        // int result = 0;
        // int currIndex = 0;

        // for (int i = 0; i < nums.Length - 1; i++)
        // {
        //     if (currIndex + nums[currIndex] >= nums.Length - 1)
        //         return ++result;

        //     int stepable = nums[currIndex];
        //     int bestStepable = 0;
        //     int maxCombination = 0;

        //     while (stepable > 0)
        //     {
        //         if (maxCombination <= stepable + nums[currIndex + stepable])
        //         {
        //             maxCombination = stepable + nums[currIndex + stepable];
        //             bestStepable = stepable;
        //         }

        //         stepable--;
        //     }

        //     if (bestStepable == 0 && currIndex < nums.Length - 1)
        //         return 0;

        //     currIndex += bestStepable;
        //     result++;
        // }

        // return result;

        // Trường hợp đặc biệt: mảng có 1 phần tử hoặc rỗng, không cần nhảy
        if (nums.Length <= 1)
        {
            return 0;
        }

        int jumps = 0;
        int currentEnd = 0;
        int farthest = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            farthest = Math.Max(farthest, i + nums[i]);

            if (i == currentEnd)
            {
                jumps++;
                currentEnd = farthest;
            }

            if (currentEnd <= i)
            {
                return -1;
            }

            if (currentEnd >= nums.Length - 1)
            {
                return jumps;
            }
        }

        return jumps;
    }
}
// @lc code=end

