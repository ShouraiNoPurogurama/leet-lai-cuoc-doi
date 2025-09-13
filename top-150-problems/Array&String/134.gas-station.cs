/*
 * @lc app=leetcode id=134 lang=csharp
 *
 * [134] Gas Station
 */

// @lc code=start
public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        //     if (gas.Length == 1)
        //         return gas[0] >= cost[0] ? 0 : -1;

        //     for (int i = 0; i < gas.Length; i++)
        //     {
        //         int costIdx = i;
        //         if (gas[i] > cost[costIdx])
        //         {
        //             int result = IsResult(i, gas, cost);

        //             if (result != -1) return result;
        //         }
        //     }
        //     return -1;
        // }

        // private int GetNextGasIdx(int curr, int[] arr)
        // {
        //     return curr < arr.Length - 1 ? ++curr : 0;
        // }

        // private int IsResult(int idx, int[] gas, int[] cost)
        // {
        //     bool success = true;
        //     int currentIdx = idx;
        //     int gasLeft = 0;

        //     for (int i = 0; i < gas.Length; i++)
        //     {
        //         gasLeft += gas[currentIdx];
        //         gasLeft -= cost[currentIdx];

        //         if (gasLeft > 0 || (gasLeft == 0 && i == gas.Length - 1))
        //         {
        //             currentIdx = GetNextGasIdx(currentIdx, gas);
        //         }
        //         else
        //         {
        //             success = false;
        //             break;
        //         }
        //     }

        //     if (success)
        //         return idx;

        //     else return -1;

        //Optimize
        int diff = 0;
        int totalGas = 0;
        int nextStart = 0;

        //Xét từng vị trí 
        for (int i = 0; i < gas.Length; i++)
        {
            diff += gas[i] - cost[i];
            totalGas += gas[i] - cost[i];

            //  Nếu cost > gas thì TẤT CẢ vị trí từ i trở về đều sẽ bị loại 
            // => kết quả nằm trong khoảng vị trí sau i
            if (diff < 0)
            {
                diff = 0;
                nextStart = i + 1;
            }
        }

        //Total gas mà bị âm thì chắc chắn ko có kết quả
        return totalGas < 0 ? -1 : nextStart;
    }
}
// @lc code=end

