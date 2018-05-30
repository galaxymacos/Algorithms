using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Binary
{
    public class AcSolution
    {
        public static string AddBinary(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int i = a.Length - 1; // the lowest digit position in string a
            int j = b.Length - 1;    // the lowest digit position in string b
            int carry = 0;    
            while (i >= 0 || j >= 0)
            {
                // Sum is made up of three portions: carry and the digit in a specific position in two numbers
                int sum = carry;    
                if (j >= 0) sum += b[j--] - '0';
                if (i >= 0) sum += a[i--] - '0';
                
                sb.Append(sum % 2);    // the number in the current position is fixed
                carry = sum / 2;    // if sum is 0 or 1, no carry; if sum is 2 or 3, has carry
            }

            // if string a and string b both have 1 in the highest position, they render 
            if (carry != 0) sb.Append(carry);
            return ReverseString(sb.ToString());
        }

        private static string ReverseString(string str)
        {
            Stack stack = new Stack();
            foreach (var c in str)
            {
                stack.Push(c);
            }

            string result = "";
            while (stack.Count > 0)
                result += stack.Pop();
            return result;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AcSolution.AddBinary("11", "10000"));
        }
    }
}