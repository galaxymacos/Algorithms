using System;

namespace Plus_One_In_Array
{
    public class Answer
    {
        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }
            
            int[] newNumber = new int[n+1];
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