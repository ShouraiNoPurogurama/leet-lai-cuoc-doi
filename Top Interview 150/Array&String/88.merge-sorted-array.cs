/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var s1Bound = m - 1; //0
        var s2Bound = n - 1; //0
        var rBound = m + n - 1; //1

        if (n == 0) return;
        if (m == 0)
        {
            Array.Copy(nums2, 0, nums1, 0, n);
            return;
        }

        if (m == 1 && n == 1)
        {
            var result = new int[2];
            if (nums1[0] > nums2[0])
            {
                result[0] = nums2[0];
                result[1] = nums1[0];
            }
            else
            {
                result[0] = nums1[0];
                result[1] = nums2[0];
            }

            nums1[0] = result[0];
            nums1[1] = result[1];
            return;
        }

        while (rBound >= 0)
        {
            if (s2Bound < 0)
                return;

            if (s1Bound < 0)
            {
                nums1[rBound--] = nums2[s2Bound--];
            }

            else
            {
                if (nums1[s1Bound] >= nums2[s2Bound])
                    nums1[rBound--] = nums1[s1Bound--];
                else
                    nums1[rBound--] = nums2[s2Bound--];
            }
        }
    }
}
// @lc code=end

