﻿namespace CSharpExt
{
    /// <summary>
    /// Provides extension methods for the 16-bit <see cref="short"/> &amp; <see cref="ushort"/> types.
    /// </summary>
    public static class Int16Extensions
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
        public static double Normalize(this short value, short rangeMin, short rangeMax, short newRangeMin, short newRangeMax)
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
        public static short NormalizeInt(this short value, short rangeMin, short rangeMax, short newRangeMin, short newRangeMax)
        {
            return (short)Normalize(value, rangeMin, rangeMax, newRangeMin, newRangeMax);
        }
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="range">The current range's (inclusive) minimum and (inclusive) maximum boundaries.</param>
        /// <param name="newRange">The (inclusive) minimum and (inclusive) maximum boundaries of the range to convert to.</param>
        /// <returns>The value as a <see cref="double"/>, normalized to the specified <paramref name="newRange"/>.</returns>
        public static double Normalize(this short value, (short Min, short Max) range, (short Min, short Max) newRange)
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
        public static short NormalizeInt(this short value, (short Min, short Max) range, (short Min, short Max) newRange)
        {
            return (short)Normalize(value, range, newRange);
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
        public static double Normalize(this ushort value, ushort rangeMin, ushort rangeMax, ushort newRangeMin, ushort newRangeMax)
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
        public static ushort NormalizeInt(this ushort value, ushort rangeMin, ushort rangeMax, ushort newRangeMin, ushort newRangeMax)
        {
            return (ushort)Normalize(value, rangeMin, rangeMax, newRangeMin, newRangeMax);
        }
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="range">The current range's (inclusive) minimum and (inclusive) maximum boundaries.</param>
        /// <param name="newRange">The (inclusive) minimum and (inclusive) maximum boundaries of the range to convert to.</param>
        /// <returns>The value as a <see cref="double"/>, normalized to the specified <paramref name="newRange"/>.</returns>
        public static double Normalize(this ushort value, (ushort Min, ushort Max) range, (ushort Min, ushort Max) newRange)
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
        public static ushort NormalizeInt(this ushort value, (ushort Min, ushort Max) range, (ushort Min, ushort Max) newRange)
        {
            return (ushort)Normalize(value, range, newRange);
        }
        #endregion Normalize (unsigned)

        #endregion Normalize
    }
}
