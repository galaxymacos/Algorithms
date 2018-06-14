using System;
using System.Linq;

namespace BestTimeToBuyAndSell
{
    public class Solution {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 1)
                return prices[0];
            return Math.Max(prices[prices.Length - 1], MaxProfit(prices.SubArray(0, prices.Length - 1)));
        }

        public int MinProfit(int[] prices)
        {
            if (prices.Length == 1)
                return prices[0];
            return Math.Min(prices[0], MinProfit(prices.SubArray(1, prices.Length - 1)));
        }

    }

    public static class ArrayExtension
    {
        public static T[] SubArray<T>(this T[] arr, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(arr, index, result, 0, length);
            return result;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution mySolution = new Solution();
            Console.WriteLine(mySolution.MaxProfit(new int[]{5,4,6,1,2}));
            Console.WriteLine(mySolution.MinProfit(new int[]{5,4,6,1,2}));
        }
    }
}