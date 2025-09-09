/*
 * @lc app=leetcode id=55 lang=csharp
 *
 * [55] Jump Game
 */

// @lc code=start
public class Solution
{
    public bool CanJump(int[] nums)
    {
        int maxReach = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > maxReach)
                return false;

            maxReach = maxReach > (nums[i] + i) ? maxReach : (nums[i] + i);

            if (maxReach > nums.Length - 1)
                return true;
        }

        return true;
    }
}
// @lc code=end

