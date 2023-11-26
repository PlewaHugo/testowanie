namespace Domain.NewDirectory
{
    public static class GreatestCommonDivisor
    {
        /// <summary>
        /// Function responsible for calculating Greatest Common Divisor using iteration/loop
        /// </summary>
        /// <param name="a">First value</param>
        /// <param name="b">Second value</param>
        /// <returns>Greatest Common Divisor (iteration)</returns>
        public static int GCDiterative(int a, int b)
        {
            while (b != 0) b = a % (a = b);
            return a;
        }

        /// <summary>
        /// Function responsible for calculating Greatest Common Divisor using recursion
        /// </summary>
        /// <param name="a">First value</param>
        /// <param name="b">Second value</param>
        /// <returns>Greatest Common Divisor (recursion)</returns>
        public static int GCDrecursive(int a, int b)
        {
            return b == 0 ? a : GCDrecursive(b, a % b);
        }
    }
}
