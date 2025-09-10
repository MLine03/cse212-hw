using System;
using System.Collections.Generic;

public class ComplexStack
{
    public static bool IsBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char ch in input)
        {
            if (ch == '(' || ch == '[' || ch == '{')
            {
                stack.Push(ch);
            }
            else if (ch == ')' || ch == ']' || ch == '}')
            {
                if (stack.Count == 0) return false;
                char top = stack.Pop();
                if (!Matches(top, ch)) return false;
            }
        }
        return stack.Count == 0;
    }

    private static bool Matches(char open, char close)
    {
        return (open == '(' && close == ')')
            || (open == '[' && close == ']')
            || (open == '{' && close == '}');
    }

    public static void Main()
    {
        var tests = new[]
        {
            "(a == 3 or (b == 5 and c == 6))",
            "(students]i].Grade > 80 and students[i].Grade < 90)",
            "(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))"
        };

        foreach (string t in tests)
        {
            bool result = IsBalanced(t);
            Console.WriteLine($"{t}\n  Balanced? {result}");
        }
    }
}
