/*
 * @lc app=leetcode id=189 lang=csharp
 *
 * [189] Rotate Array
 */

// @lc code=start
public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        // int[] result = new int[nums.Length];

        // for (int i = 0; i < nums.Length; i++)
        // {
        //     int newIndex = i + k;

        //     while (newIndex > nums.Length - 1)
        //     {
        //         newIndex -= nums.Length;
        //     }

        //     result[newIndex] = nums[i];
        // }

        // for (int i = 0; i < nums.Length; i++)
        // {
        //     nums[i] = result[i];
        // }

        //Nên xài chia để trị
        //Có thể chia quy trình đảo ngược theo đề bài thành 3 bước
        //1. Đảo ngược cả mảng
        //2. Đảo ngược k phần tử đầu đề yêu cầu để nó về đúng thứ tự
        //3. Đảo ngược các phần tử còn lại để nó về đúng thứ tự.

        //Rút gọn k
        int actualSteps = k % nums.Length;

        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, actualSteps - 1);
        Reverse(nums, actualSteps, nums.Length - 1);
    }

    private void Reverse(int[] input, int leftBound, int rightBound)
    {
        while (leftBound < rightBound)
        {
            (input[leftBound], input[rightBound]) = (input[rightBound], input[leftBound]);
            leftBound++;
            rightBound--;
        }
    }
}
// @lc code=end

