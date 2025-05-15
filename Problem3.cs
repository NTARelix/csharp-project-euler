namespace myproject
{
    public static class Problem3
    {
        private static bool IsPrime(long num)
        {
            long max = num / 2;
            for (long potential = 2; potential < max; potential += 1)
            {
                if (num % potential == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static long GetSolution(long num)
        {
            long largestPrimeFactor = 1;
            long max = (long)Math.Floor(Math.Sqrt(num));
            for (long potential = 2; potential < max; potential++)
            {
                if (num % potential == 0 && IsPrime(potential))
                {
                    largestPrimeFactor = potential;
                }
            }
            return largestPrimeFactor;
        }
    }
}