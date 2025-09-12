// /*
//  * @lc app=leetcode id=274 lang=csharp
//  *
//  * [274] H-Index
//  */

// @lc code=start
public class Solution
{
    public int HIndex(int[] citations)
    {
//         //     if (citations.Length == 0)
//         //         return 0;

//         //     if (citations.Length == 1)
//         //     {
//         //         if (citations[0] == 0)
//         //             return 0;
//         //         else return 1;
//         //     }

//         //     (int index, int smallerThanCount) hIndexCombination = (0, 0);
//         //     Dictionary<int, int> distincValues = new Dictionary<int, int>();

//         //     for (int i = 0; i < citations.Length; i++)
//         //     {
//         //         if (citations[i] == 0)
//         //             continue;

//         //         int curr = citations[i];

//         //         if (!distincValues.TryGetValue(curr, out var value))
//         //         {
//         //             distincValues.Add(curr, 1);
//         //         }
//         //         else
//         //         {
//         //             distincValues[curr]++;
//         //         }
//         //     }

//         //     foreach (int entry in distincValues.Keys)
//         //     {
//         //         int smallerThanCount = 0;
//         //         var currentHIndex = (entry, 0);

//         //         //Tìm số phần tử mà entry này có citiation ít hơn
//         //         for (int i = 0; i < citations.Length; i++)
//         //         {
//         //             if (entry <= citations[i])
//         //             {
//         //                 smallerThanCount++;
//         //             }
//         //         }

//         //         //Ưu tiên độ lớn của index => Item2 chỉ cần == index hoặc trở lên là được
//         //         currentHIndex = (entry, smallerThanCount);
//         //         currentHIndex.Item2 = Math.Min(currentHIndex.entry, currentHIndex.Item2);

//         //         if (currentHIndex.Item2 > hIndexCombination.smallerThanCount)
//         //         {
//         //             hIndexCombination = currentHIndex;
//         //         }
//         //     }

//         //     return hIndexCombination.smallerThanCount;
//         // }

//         //TIME TO OPTIMIZE

        if (citations.Length == 0)
            return 0;

        if (citations.Length == 1)
        {
            if (citations[0] == 0)
                return 0;

            else return 1;
        }

        (int index, int smallerThanCount) hIndexCombination = (0, 0);
        Dictionary<int, bool> checkedItem = new();

        for (int i = 0; i < citations.Length; i++)
        {
            int entry = citations[i];

            if (checkedItem.ContainsKey(entry) || entry == 0)
                continue;

            int smallerThanCount = 0;

            var currentHIndex = (entry, 0);

            for (int j = 0; j < citations.Length; j++)
            {
                if (smallerThanCount >= entry)
                    break;

                if (entry <= citations[j])
                    {
                        smallerThanCount++;
                    }
            }

            //Ưu tiên độ lớn của index => Item2 chỉ cần == index hoặc trở lên là được
            currentHIndex = (entry, smallerThanCount);

            if (currentHIndex.Item2 > hIndexCombination.smallerThanCount)
            {
                hIndexCombination = currentHIndex;
            }

            checkedItem[entry] = true;
        }

        return hIndexCombination.smallerThanCount;
    }
}


// @lc code=end


