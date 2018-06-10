namespace ClimbingStairs
{
    public class Memorization
    {
        public int ClimbStairs(int n)
        {
            int[] memo = new int[n+1];
            return Climb_Stairs(0, n, memo);
        }

        private int Climb_Stairs(int i, int n, int[] memo)
        {
            if (i > n) return 0;
            if (i == n) return 1;
            if (memo[i] > 0) return memo[i];
            memo[i] = Climb_Stairs(i + 1, n, memo) + Climb_Stairs(i + 2, n, memo);
            return memo[i];
        }
    }
}