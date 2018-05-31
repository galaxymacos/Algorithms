using System;
using System.Collections.Generic;

namespace Permutation
{
    public class MyClass
    {
        public static List<List<int>> Permute(int[] nums)
        {
            if (nums.Length == 1)
            {
                List<List<int>> oneElementList = new List<List<int>> {new List<int> {1}};
                return oneElementList;
            }
            int[] head = new int[nums.Length-1];
            for (int i = 0; i < head.Length; i++)
            {
                head[i] = nums[i];
            }

            int tail = nums[nums.Length - 1];

            List<List<int>> arrFromHead = Permute(head);
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < arrFromHead.Count; i++)
            {
                for (int j = 0; j <= arrFromHead[i].Count; j++)
                {
                    List<int> copiedList = new List<int>();
                    foreach (int i1 in arrFromHead[i])
                    {
                        copiedList.Add(i1);
                    }
                    copiedList.Insert(j,tail);
                    result.Add(copiedList);
                }
            }

            return result;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arrayA = {1,2};
            List<List<int>> result = MyClass.Permute(arrayA);
            foreach (var row in result)
            {
                foreach (int i in row)
                {
                    Console.Write(i+" ");
                }

                Console.WriteLine();
            }
        }
    }
}