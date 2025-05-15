namespace myproject
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine($"Solution 1: {Problem1.GetSolution(1_000)}");
            Console.WriteLine($"Solution 2: {Problem2.GetSolution(4_000_000)}");
            Console.WriteLine($"Solution 3: {Problem3.GetSolution(600_851_475_143)}");
            Console.WriteLine($"Solution 4: {Problem4.GetSolution(3)}");
        }
    }
}