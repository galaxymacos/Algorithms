using System;

namespace RemoveElement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {4,5};
            Console.WriteLine($"Length of {nameof(arr)} is {MyClass.RemoveElement(arr, 5)}");
            foreach (var i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}