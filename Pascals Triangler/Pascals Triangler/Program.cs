using System;
using System.Collections.Generic;

namespace Pascals_Triangler
{
    
    public class Solution {
        public IList<IList<int>> Generate(int numIndex)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (numIndex < 1) return result;
            result.Add(new List<int>{1});
            if (numIndex == 1)
                return result;
            for (int row = 2; row <= numIndex; row++)
            {
                IList<int> previousRow = result[row - 2];
                IList<int> newList = new List<int> {1};

                for (int i = 1; i < previousRow.Count; i++)
                {
                    newList.Add( previousRow[i - 1] + previousRow[i]);
                }
                newList.Add(1);
                result.Add(newList);
            }

            return result;
        }
        
        public IList<int> GenerateRow(int rowIndex)
        {
            IList<int> result = new List<int>();
            if (rowIndex < 0) return result;
            result.Add(1);
            if (rowIndex == 0)
                return result;
            for (int row = 0; row < rowIndex; row++)
            {
                IList<int> newList = new List<int> {1};

                for (int i = 1; i < result.Count; i++)
                {
                    newList.Add( result[i - 1] + result[i]);
                }
                newList.Add(1);
                result = newList;
            }

            return result;
        }
    }
    internal class Program
    {
        public static void print(IList<IList<int>> list)
        {
            foreach (IList<int> ints in list)
            {
                foreach (int i in ints)
                {
                    Console.Write(i+" ");
                }

                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            var tri = solution.GenerateRow(3);
            foreach (int i in tri)
            {
                Console.Write(i+" ");
            }
        }
    }
}