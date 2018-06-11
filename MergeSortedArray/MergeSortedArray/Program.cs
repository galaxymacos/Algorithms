using System;

namespace MergeSortedArray
{
    public class MyClass
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] total = new int[nums1.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i != m || j != n)
            {
                if (i == m)
                {
                    total[k] = nums2[j];
                    j++;
                }
                else if (j == n)
                {
                    total[k] = nums1[i];
                    i++;
                }
                else if (nums1[i] <= nums2[j])
                {
                    Console.WriteLine(k + " " + i);
                    total[k] = nums1[i];
                    i++;
                }
                else if (nums1[i] > nums2[j])
                {
                    total[k] = nums2[j];
                    j++;
                }

                k++;
            }

            for (int l = 0; l < nums1.Length; l++)
            {
                nums1[l] = total[l];
            }
        }

        public void Merge2(int[] nums1, int m, int[] nums2, int n)
        {
            if (nums2.Length == 0)
                return;
            int i = 0;
            
            while (i<m)
            {
                int j = 0;
                if (nums1[i] <= nums2[j])
                {
                    i++;
                    continue;
                }
                int temp = nums1[i];
                nums1[i] = nums2[j];
                while (j+1<nums2.Length&&nums2[j + 1] < temp)
                {
                    nums2[j] = nums2[j + 1];
                    j++;
                }

                nums2[j] = temp;
            }

            for (int k = i; k < nums1.Length; k++)
            {
                nums1[k] = nums2[k - i];
            }
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            int[] nums1 = {-1,0,0,3,3,3,0,0,0};
            int[] nums2 = {1, 2, 2};
            myClass.Merge2(nums1, 6, nums2, 3);
            foreach (int i in nums1)
            {
                Console.Write(i + " ");
            }

        }
    }
}