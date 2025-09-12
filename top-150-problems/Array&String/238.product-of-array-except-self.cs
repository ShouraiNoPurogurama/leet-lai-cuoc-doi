/*
 * @lc app=leetcode id=238 lang=csharp
 *
 * [238] Product of Array Except Self
 */

// @lc code=start
public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        // int totalProduct = 1;
        // bool productValueChanged = false;

        // List<int> zeroIndexes = new();

        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (nums[i] != 0)
        //     {
        //         totalProduct *= nums[i];
        //         productValueChanged = true;
        //     }
        //     else
        //     {
        //         zeroIndexes.Add(i);
        //     }
        // }

        // if (!productValueChanged || zeroIndexes.Count >= 2)
        // {
        //     return new int[nums.Length];
        // }

        // else if (zeroIndexes.Count == 1)
        // {
        //     var dummy = new int[nums.Length];

        //     dummy[zeroIndexes.First()] = totalProduct;

        //     return dummy;
        // }

        // else
        // {
        //     for (int i = 0; i < nums.Length; i++)
        //     {
        //         nums[i] = totalProduct / nums[i];
        //     }
        // }

        // return nums;

        //OPTIMIZE

        int[] result = new int[nums.Length];
        int rightProduct = 1;
        int leftProduct = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = leftProduct;
            leftProduct *= nums[i];
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= rightProduct;
            rightProduct *= nums[i];
        }

        return result;
    }
}
// @lc code=end

