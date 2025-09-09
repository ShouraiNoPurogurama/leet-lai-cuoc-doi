/*
 * @lc app=leetcode id=122 lang=csharp
 *
 * [122] Best Time to Buy and Sell Stock II
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int min = prices[0];
        int totalProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > min)
            {
                totalProfit += prices[i] - min;
            }
            
            min = prices[i];
        }

        return totalProfit;
    }

}
// @lc code=end

