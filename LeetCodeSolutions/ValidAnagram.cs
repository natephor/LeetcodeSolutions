namespace LeetCodeSolutions;

// 242. Valid Anagram - https://leetcode.com/problems/valid-anagram/description/
public class ValidAnagram
{
    public bool Solution(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var counts = new int[26];
        for (var i = 0; i < s.Length; i++)
        {
            var sIndex = s[i] - 'a';
            var tIndex = t[i] - 'a';
            counts[sIndex]++;
            counts[tIndex]--;
        }

        return counts.All(n => n == 0);
    }
}