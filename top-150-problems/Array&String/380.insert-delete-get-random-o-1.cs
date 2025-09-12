/*
 * @lc app=leetcode id=380 lang=csharp
 *
 * [380] Insert Delete GetRandom O(1)
 */

// @lc code=start
public class RandomizedSet
{
    private Dictionary<int, int> valueToIdx;
    private List<int> valueReplications;
    private Random random;

    public RandomizedSet()
    {
        valueToIdx = new();
        valueReplications = new();
        random = new();
    }

    public bool Insert(int val)
    {
        if (valueToIdx.ContainsKey(val))
            return false;

        valueReplications.Add(val);
        valueToIdx.Add(val, valueReplications.Count - 1);

        return true;
    }

    public bool Remove(int val)
    {
        if (!valueToIdx.ContainsKey(val))
            return false;

        //Swap element cần xóa về cuối list để đạt O(1)
        int idx = valueToIdx[val];
        int lastValue = valueReplications[valueReplications.Count - 1];

        valueReplications[idx] = lastValue;
        valueToIdx[lastValue] = idx;

        valueReplications.RemoveAt(valueReplications.Count - 1);
        valueToIdx.Remove(val);

        return true;
    }

    public int GetRandom()
    {
        return valueReplications[random.Next(valueReplications.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
// @lc code=end

