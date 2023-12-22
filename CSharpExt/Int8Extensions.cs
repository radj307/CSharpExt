namespace CSharpExt
{
    /// <summary>
    /// Provides extension methods for the 8-bit <see cref="byte"/> type.
    /// </summary>
    public static class Int8Extensions
    {
        #region Normalize
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="rangeMin">The current range's (inclusive) minimum boundary.</param>
        /// <param name="rangeMax">The current range's (inclusive) maximum boundary.</param>
        /// <param name="newRangeMin">The (inclusive) minimum boundary of the range to convert to.</param>
        /// <param name="newRangeMax">The (inclusive) maximum boundary of the range to convert to.</param>
        /// <returns>The value as a <see cref="double"/>, normalized to the specified <paramref name="newRangeMin"/> &amp; <paramref name="newRangeMax"/>.</returns>
        public static double Normalize(this byte value, byte rangeMin, byte rangeMax, byte newRangeMin, byte newRangeMax)
        {
            return newRangeMin + (value - rangeMin) * (newRangeMax - newRangeMin) / (rangeMax - rangeMin);
        }
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="rangeMin">The current range's (inclusive) minimum boundary.</param>
        /// <param name="rangeMax">The current range's (inclusive) maximum boundary.</param>
        /// <param name="newRangeMin">The (inclusive) minimum boundary of the range to convert to.</param>
        /// <param name="newRangeMax">The (inclusive) maximum boundary of the range to convert to.</param>
        /// <returns>The truncated value, normalized to the specified <paramref name="newRangeMin"/> &amp; <paramref name="newRangeMax"/>.</returns>
        public static byte NormalizeInt(this byte value, byte rangeMin, byte rangeMax, byte newRangeMin, byte newRangeMax)
        {
            return (byte)Normalize(value, rangeMin, rangeMax, newRangeMin, newRangeMax);
        }
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="range">The current range's (inclusive) minimum and (inclusive) maximum boundaries.</param>
        /// <param name="newRange">The (inclusive) minimum and (inclusive) maximum boundaries of the range to convert to.</param>
        /// <returns>The value as a <see cref="double"/>, normalized to the specified <paramref name="newRange"/>.</returns>
        public static double Normalize(this byte value, (byte Min, byte Max) range, (byte Min, byte Max) newRange)
        {
            return newRange.Min + (value - range.Min) * (newRange.Max - newRange.Min) / (range.Max - range.Min);
        }
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="range">The current range's (inclusive) minimum and (inclusive) maximum boundaries.</param>
        /// <param name="newRange">The (inclusive) minimum and (inclusive) maximum boundaries of the range to convert to.</param>
        /// <returns>The truncated value, normalized to the specified <paramref name="newRange"/>.</returns>
        public static byte NormalizeInt(this byte value, (byte Min, byte Max) range, (byte Min, byte Max) newRange)
        {
            return (byte)Normalize(value, range, newRange);
        }
        #endregion Normalize
    }
}
