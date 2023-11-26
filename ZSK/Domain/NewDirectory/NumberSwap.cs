namespace Domain.NewDirectory
{
    public static class NumberSwap
    {
        /// <summary>
        /// Function responsible for swapping 2 integers using temporary variable
        /// </summary>
        /// <param name="x">First number</param>
        /// <param name="y">Second number</param>
        /// <param name="resultX">First number (result)</param>
        /// <param name="resultY">Second number (result)</param>
        public static void NormalVariableSwap(int x, int y, out int resultX, out int resultY)
        {
            var temp = x;   //Integer swap using temporary variable
            resultX = y;
            resultY = temp;
        }

        /// <summary>
        /// Function responsible for swapping 2 integers using "magic"
        /// </summary>
        /// <param name="x">First number</param>
        /// <param name="y">Second number</param>
        /// <param name="resultX">First number (result)</param>
        /// <param name="resultY">Second number (result)</param>
        public static void MagicVariableSwap(int x, int y, out int resultX, out int resultY)
        {
            x = x + y - (y = x);    //single line integer swap
            resultX = x;
            resultY = y;
        }
    }
}
