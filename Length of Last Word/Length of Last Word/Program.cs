using System;

namespace Length_of_Last_Word
{
    public class MyClass
    {
        public static int LengthOfLastWord(string s)
        {
            var words = s.Trim().Split(' ');
            return words[words.Length - 1].Length;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MyClass.LengthOfLastWord("Hello World"));
        }
    }
}