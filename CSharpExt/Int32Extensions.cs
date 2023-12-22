namespace CSharpExt
{
    /// <summary>
    /// Provides extension methods for the 32-bit <see cref="int"/> &amp; <see cref="uint"/> types.
    /// </summary>
    public static class Int32Extensions
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
        public static double Normalize(this int value, int rangeMin, int rangeMax, int newRangeMin, int newRangeMax)
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
        public static int NormalizeInt(this int value, int rangeMin, int rangeMax, int newRangeMin, int newRangeMax)
        {
            return (int)Normalize(value, rangeMin, rangeMax, newRangeMin, newRangeMax);
        }
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="range">The current range's (inclusive) minimum and (inclusive) maximum boundaries.</param>
        /// <param name="newRange">The (inclusive) minimum and (inclusive) maximum boundaries of the range to convert to.</param>
        /// <returns>The value as a <see cref="double"/>, normalized to the specified <paramref name="newRange"/>.</returns>
        public static double Normalize(this int value, (int Min, int Max) range, (int Min, int Max) newRange)
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
        public static int NormalizeInt(this int value, (int Min, int Max) range, (int Min, int Max) newRange)
        {
            return (int)Normalize(value, range, newRange);
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
        public static double Normalize(this uint value, uint rangeMin, uint rangeMax, uint newRangeMin, uint newRangeMax)
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
        public static uint NormalizeInt(this uint value, uint rangeMin, uint rangeMax, uint newRangeMin, uint newRangeMax)
        {
            return (uint)Normalize(value, rangeMin, rangeMax, newRangeMin, newRangeMax);
        }
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="range">The current range's (inclusive) minimum and (inclusive) maximum boundaries.</param>
        /// <param name="newRange">The (inclusive) minimum and (inclusive) maximum boundaries of the range to convert to.</param>
        /// <returns>The value as a <see cref="double"/>, normalized to the specified <paramref name="newRange"/>.</returns>
        public static double Normalize(this uint value, (uint Min, uint Max) range, (uint Min, uint Max) newRange)
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
        public static uint NormalizeInt(this uint value, (uint Min, uint Max) range, (uint Min, uint Max) newRange)
        {
            return (uint)Normalize(value, range, newRange);
        }
        #endregion Normalize (unsigned)

        #endregion Normalize
    }
}
