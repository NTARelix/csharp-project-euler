namespace myproject
{
    public static class Problem1
    {
        public static long GetSolution(long num)
        {
            long sum = 0;
            for (long i = 0; i < num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}