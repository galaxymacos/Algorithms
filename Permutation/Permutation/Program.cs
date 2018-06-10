using System;
using System.Collections.Generic;

namespace Permutation
{
    public class MyClass
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            if (nums.Length == 1)
            {
                IList<IList<int>> oneElementList = new List<IList<int>> {new List<int> {nums[0]}};
                return oneElementList;
            }
            int[] head = new int[nums.Length-1];
            for (int i = 0; i < head.Length; i++)
            {
                head[i] = nums[i];
            }

            int tail = nums[nums.Length - 1];

            IList<IList<int>> arrFromHead = Permute(head);
            IList<IList<int>> result = new List<IList<int>>();
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
            int[] arrayA = {0,2};
            IList<IList<int>> result = MyClass.Permute(arrayA);
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