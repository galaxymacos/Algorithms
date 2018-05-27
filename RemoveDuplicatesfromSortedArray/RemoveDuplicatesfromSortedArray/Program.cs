using System;

namespace RemoveDuplicatesfromSortedArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {0, 0, 1, 1, 2, 2, 3, 3, 4};
            TwoPointers.RemoveDuplicates(arr);
            foreach (var i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}