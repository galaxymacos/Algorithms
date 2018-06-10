using System.Collections.Generic;

namespace ClimbingStairs
{
    public class MyClass
    {
        readonly List<int> _list = new List<int> {1, 2};

        public int ClimbStairs(int n)
        {
            if (n - 1 < _list.Count)
                return _list[n - 1];
            _list.Add(ClimbStairs(n - 1) + ClimbStairs(n - 2));
            return _list[n - 1];
        }
    }
}