/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int min = prices[0];
        int max = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > min)
            {
                if (prices[i] - min > maxProfit)
                {
                    maxProfit = prices[i] - min;
                    max = prices[i];
                }
            }
            else
            {
                min = prices[i];
            }
        }

        return maxProfit;
    }
}
// @lc code=end

