namespace myproject
{
    public static class Problem2
    {
        public static long GetSolution(long num)
        {
            long prev = 1;
            long curr = 2;
            long sum = 0;
            while (curr < num)
            {
                if (curr % 2 == 0)
                {
                    sum += curr;
                }
                curr += prev;
                prev = curr - prev;
            }
            return sum;
        }
    }
}