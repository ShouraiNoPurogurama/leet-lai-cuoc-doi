/*
 * @lc app=leetcode id=135 lang=csharp
 *
 * [135] Candy
 */

// @lc code=start
public class Solution
{
    public int Candy(int[] ratings)
    {
        int totalCandies = 0;
        int[] populatedCandies = new int[ratings.Length];

        for (int i = 0; i < ratings.Length; i++)
        {
            populatedCandies[i] = 1;
        }

        //Duyệt từ trái qua để đảm bảo thằng sau luôn có kẹo nhiều hơn thằng trước nếu điểm nó cao hơn
        for (int i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                populatedCandies[i] = populatedCandies[i - 1] + 1;
            }
        }

        totalCandies += populatedCandies[ratings.Length - 1];
        //Giờ duyệt từ phải về theo tư duy kẹo của thằng bên trái có rating cao hơn thì = kẹo bên phải + 1 hoặc kẹo bên trái nếu nó cao hơn sẵn rồi
        for (int i = ratings.Length - 1; i > 0; i--)
        {
            if (ratings[i - 1] > ratings[i])
            {
                populatedCandies[i - 1] = Math.Max(populatedCandies[i - 1], populatedCandies[i] + 1);
            }
            totalCandies += populatedCandies[i - 1];
        }

        return totalCandies;
    }
}

// @lc code=end

