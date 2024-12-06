namespace LeetCodeSolutions;

// 20. Valid Parentheses - https://leetcode.com/problems/valid-parentheses/description/
public class ValidParentheses
{
    public bool IsValid(string s)
    {
        var closers = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

        var stack = new Stack<char>();
        foreach (var ch in s)
            if (closers.TryGetValue(ch, out var closer))
                stack.Push(closer);
            else if (stack.Count == 0 || stack.Pop() != ch)
                return false;

        return stack.Count == 0;
    }
}