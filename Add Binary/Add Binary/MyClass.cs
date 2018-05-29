using System;
using System.Collections.Generic;

namespace Add_Binary
{
    public class MyClass
    {
        public static string AddBinary(string a, string b)
        {
            Stack<int> stack = new Stack<int>();
            if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b))
            {
                return a ?? b;
            }
            int minLength = Math.Min(a.Length, b.Length);
            int maxLength = Math.Max(a.Length, b.Length);
            bool carry = false;
            for (int i = minLength - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(a[i]-'0') + Convert.ToInt32(b[i]-'0') + (carry ? 1 : 0) >= 2)
                {
                    if(a.Length<b.Length)
                        stack.Push(Convert.ToInt32(a[i]-'0') + Convert.ToInt32(b[i+(maxLength-minLength)]-'0') + (carry ? 1 : 0) - 2);
                    else
                    {
                        stack.Push(Convert.ToInt32(a[i+(maxLength-minLength)]-'0') + Convert.ToInt32(b[i]-'0') + (carry ? 1 : 0) - 2);
                    }
                    carry = true;
                }
                else
                {
                    if(a.Length<b.Length)
                        stack.Push(Convert.ToInt32(a[i]-'0') + Convert.ToInt32(b[i+(maxLength-minLength)]-'0'));
                    else
                    {
                        stack.Push(Convert.ToInt32(a[i+(maxLength-minLength)]-'0') + Convert.ToInt32(b[i]-'0'));
                    }
                    carry = false;
                }

                if (i != 0) continue;
               
                int[] arr = new int[maxLength];
                for (int j = 0; j < maxLength - minLength; j++)
                {
                    if (a.Length > b.Length)
                    {
                        arr[j] = a[j];
                    }
                    else
                    {
                        arr[j] = b[j];
                    }
                }
                for (int j = maxLength - minLength; j < maxLength; j++)
                {
                    arr[j] = stack.Pop();
                }

                if (carry == false)
                    return string.Join("", arr);
                return "1" + string.Join("", arr);
            }

            throw new ArgumentNullException("arr");
        }
    }
}