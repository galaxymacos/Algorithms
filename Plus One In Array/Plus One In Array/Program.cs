using System;

namespace Plus_One_In_Array
{
    public class Answer
    {
        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)    // loop through digits
            {
                if (digits[i] < 9)    // if no need to carry
                {
                    digits[i]++;    // current position will be +=1
                    return digits;    // Finish
                }

                digits[i] = 0;    // current position will be 9+1 = 0, carry to the next digit
            }
            
            // means there are carries all from the lowerest digit up to the highest digit (Ex: 9999)
            var newNumber = new int[n+1];
            newNumber[0] = 1;
            return newNumber;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {9,5,0};
            int[] result = Answer.PlusOne(arr);
            foreach (var i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}