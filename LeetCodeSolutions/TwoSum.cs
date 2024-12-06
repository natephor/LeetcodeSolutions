namespace LeetCodeSolutions;

// 1. Two Sum - https://leetcode.com/problems/two-sum/description/
public class TwoSum
{
    public int[] Solution(int[] nums, int target)
    {
        var numToIndex = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var lookup = target - nums[i];
            if (numToIndex.TryGetValue(lookup, out var lookupIndex))
                return [i, lookupIndex];
            numToIndex[nums[i]] = i;
        }

        return [];
    }
}