namespace myproject
{
    public static class Problem4
    {
        private static bool IsPalindrome(ulong num)
        {
            string forwardString = num.ToString();
            char[] charArray = forwardString.ToCharArray();
            Array.Reverse(charArray);
            string backwardString = new string(charArray);
            return forwardString.Equals(backwardString);
        }

        public static ulong? GetSolution(byte num)
        {
            ulong minElement = (ulong)Math.Pow(10, num - 1);
            ulong maxElement = (ulong)Math.Pow(10, num) - 1;
            ulong? largest = null;
            for (ulong element1 = maxElement; element1 >= minElement; element1--)
            {
                for (ulong element2 = element1; element2 >= minElement; element2--)
                {
                    ulong product = element1 * element2;
                    if (largest != null && product < largest)
                    {
                        // none of the remaining `element2` values will result in a product larger than `largest` at the current `element1` value
                        // so move onto the next `element1` value
                        break;
                    }
                    if ((largest == null || product > largest) && IsPalindrome(product))
                    {
                        largest = product;
                    }
                }
            }
            return largest;
        }
    }
}
