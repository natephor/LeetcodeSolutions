namespace LeetCodeSolutions;

// 217. Contains Duplicate (5/12/2024)
// https://leetcode.com/problems/contains-duplicate/description/
public class ContainsDuplicate
{
    public bool Solution(int[] nums)
    {
        var found = new HashSet<int>();
        return nums.Any(num => !found.Add(num));
    }
}