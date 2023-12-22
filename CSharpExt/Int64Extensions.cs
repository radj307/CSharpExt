namespace CSharpExt
{
    /// <summary>
    /// Provides extension methods for the 64-bit <see cref="long"/> &amp; <see cref="ulong"/> types.
    /// </summary>
    public static class Int64Extensions
    {
        #region Normalize

        #region Normalize (signed)
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="rangeMin">The current range's (inclusive) minimum boundary.</param>
        /// <param name="rangeMax">The current range's (inclusive) maximum boundary.</param>
        /// <param name="newRangeMin">The (inclusive) minimum boundary of the range to convert to.</param>
        /// <param name="newRangeMax">The (inclusive) maximum boundary of the range to convert to.</param>
        /// <returns>The value as a <see cref="double"/>, normalized to the specified <paramref name="newRangeMin"/> &amp; <paramref name="newRangeMax"/>.</returns>
        public static double Normalize(this long value, long rangeMin, long rangeMax, long newRangeMin, long newRangeMax)
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
        public static long NormalizeInt(this long value, long rangeMin, long rangeMax, long newRangeMin, long newRangeMax)
        {
            return (long)Normalize(value, rangeMin, rangeMax, newRangeMin, newRangeMax);
        }
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="range">The current range's (inclusive) minimum and (inclusive) maximum boundaries.</param>
        /// <param name="newRange">The (inclusive) minimum and (inclusive) maximum boundaries of the range to convert to.</param>
        /// <returns>The value as a <see cref="double"/>, normalized to the specified <paramref name="newRange"/>.</returns>
        public static double Normalize(this long value, (long Min, long Max) range, (long Min, long Max) newRange)
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
        public static long NormalizeInt(this long value, (long Min, long Max) range, (long Min, long Max) newRange)
        {
            return (long)Normalize(value, range, newRange);
        }
        #endregion Normalize (signed)

        #region Normalize (unsigned)
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="rangeMin">The current range's (inclusive) minimum boundary.</param>
        /// <param name="rangeMax">The current range's (inclusive) maximum boundary.</param>
        /// <param name="newRangeMin">The (inclusive) minimum boundary of the range to convert to.</param>
        /// <param name="newRangeMax">The (inclusive) maximum boundary of the range to convert to.</param>
        /// <returns>The value as a <see cref="double"/>, normalized to the specified <paramref name="newRangeMin"/> &amp; <paramref name="newRangeMax"/>.</returns>
        public static double Normalize(this ulong value, ulong rangeMin, ulong rangeMax, ulong newRangeMin, ulong newRangeMax)
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
        public static ulong NormalizeInt(this ulong value, ulong rangeMin, ulong rangeMax, ulong newRangeMin, ulong newRangeMax)
        {
            return (ulong)Normalize(value, rangeMin, rangeMax, newRangeMin, newRangeMax);
        }
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="range">The current range's (inclusive) minimum and (inclusive) maximum boundaries.</param>
        /// <param name="newRange">The (inclusive) minimum and (inclusive) maximum boundaries of the range to convert to.</param>
        /// <returns>The value as a <see cref="double"/>, normalized to the specified <paramref name="newRange"/>.</returns>
        public static double Normalize(this ulong value, (ulong Min, ulong Max) range, (ulong Min, ulong Max) newRange)
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
        public static ulong NormalizeInt(this ulong value, (ulong Min, ulong Max) range, (ulong Min, ulong Max) newRange)
        {
            return (ulong)Normalize(value, range, newRange);
        }
        #endregion Normalize (unsigned)

        #endregion Normalize
    }
}
