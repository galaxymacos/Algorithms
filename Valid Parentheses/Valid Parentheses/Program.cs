using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace Valid_Parentheses
{
    public class MyClass
    {
        public static bool FindParentheses(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            var pStack = new Stack<char>();
            var parenthesesPair = new Dictionary<char, char> {{'(', ')'}, {'[', ']'}, {'{', '}'}};

            foreach (char parenthese in s)
            {
                if (parenthesesPair.ContainsKey(parenthese))
                {
                    pStack.Push(parenthese);
                }
                else if (pStack.Count > 0 && parenthesesPair[pStack.Peek()] == parenthese)
                {
                    pStack.Pop();
                }
                else return false;
            }

            return pStack.Count == 0;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MyClass.FindParentheses("{[]}"));
        }
    }
}