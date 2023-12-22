using System;

namespace CSharpExt
{
    /// <summary>
    /// Provides extension methods for the <see cref="double"/> type.
    /// </summary>
    public static class DoubleExtensions
    {
        #region Constant Fields
        /// <summary>
        /// Maximum difference between two equal <see cref="double"/> numbers.
        /// </summary>
        public const double Epsilon = 1E-09f;
        #endregion Constant Fields

        #region EqualsWithin (double, double)
        /// <summary>
        /// Checks if the specified <see cref="double"/> values are equal, within the specified deviation.
        /// </summary>
        /// <param name="l"/>
        /// <param name="r">A <see cref="double"/> to check equality with.</param>
        /// <param name="within">The maximum difference between the double values that can be considered equal.</param>
        /// <returns><see langword="true"/> when equal; otherwise, <see langword="false"/>.</returns>
        public static bool EqualsWithin(this double l, double r, double within = Epsilon)
        {
            return (double.IsInfinity(l) && double.IsInfinity(r))
                || (double.IsNaN(l) && double.IsNaN(r))
                || Math.Abs(l - r) < within;
        }
        /// <summary>
        /// Checks if the specified <see cref="double"/> values are equal, within the specified deviation.
        /// </summary>
        /// <param name="l"/>
        /// <param name="r">A <see cref="double"/> to check equality with.</param>
        /// <param name="within">The maximum difference between the double values that can be considered equal.</param>
        /// <returns><see langword="true"/> when equal; otherwise, <see langword="false"/>.</returns>
        public static bool EqualsWithin(this double? l, double? r, double within = Epsilon)
        {
            bool lHasValue = l.HasValue;
            bool rHasValue = r.HasValue;
            if (!lHasValue || !rHasValue)
            {
                return lHasValue == rHasValue;
            }

            return (double.IsInfinity(l.Value) && double.IsInfinity(r.Value))
                || (double.IsNaN(l.Value) && double.IsNaN(r.Value))
                || Math.Abs(l.Value - r.Value) < within;
        }
        #endregion EqualsWithin (double, double)

        #region EqualsWithin (double, double)
        /// <summary>
        /// Checks if the specified <see cref="double"/> value &amp; <see cref="float"/> value are equal, within the specified deviation.
        /// </summary>
        /// <param name="l"/>
        /// <param name="r">A <see cref="double"/> to check equality with.</param>
        /// <param name="within">The maximum difference between the double values that can be considered equal.</param>
        /// <returns><see langword="true"/> when equal; otherwise, <see langword="false"/>.</returns>
        public static bool EqualsWithin(this double l, float r, double within = Epsilon)
        {
            return (double.IsInfinity(l) && float.IsInfinity(r))
                || (double.IsNaN(l) && float.IsNaN(r))
                || Math.Abs(l - r) < within;
        }
        /// <summary>
        /// Checks if the specified <see cref="double"/> value &amp; <see cref="float"/> value are equal, within the specified deviation.
        /// </summary>
        /// <param name="l"/>
        /// <param name="r">A <see cref="double"/> to check equality with.</param>
        /// <param name="within">The maximum difference between the double values that can be considered equal.</param>
        /// <returns><see langword="true"/> when equal; otherwise, <see langword="false"/>.</returns>
        public static bool EqualsWithin(this double? l, float? r, double within = Epsilon)
        {
            bool lHasValue = l.HasValue;
            bool rHasValue = r.HasValue;
            if (!lHasValue || !rHasValue)
            {
                return lHasValue == rHasValue;
            }

            return (double.IsInfinity(l.Value) && float.IsInfinity(r.Value))
                || (double.IsNaN(l.Value) && float.IsNaN(r.Value))
                || Math.Abs(l.Value - r.Value) < within;
        }
        #endregion EqualsWithin (double, double)

        #region ClampToBounds
        /// <summary>
        /// Clamps the <see cref="double"/> value within the specified <paramref name="min"/> and <paramref name="max"/> boundaries.
        /// </summary>
        /// <param name="value"/>
        /// <param name="min">The (inclusive) minimum boundary value.</param>
        /// <param name="max">The (inclusive) maximum boundary value.</param>
        /// <returns>A <see cref="double"/> value within the <paramref name="min"/> and <paramref name="max"/> bounds.</returns>
        public static double ClampToBounds(this double value, double min, double max)
        {
            if (value > max)
                return max;
            if (value < min)
                return min;
            return value;
        }
        /// <summary>
        /// Clamps the <see cref="double"/> value within the specified <paramref name="bounds"/>.
        /// </summary>
        /// <param name="value"/>
        /// <param name="bounds">The (inclusive) minimum and (inclusive) maximum boundary values.</param>
        /// <returns>A <see cref="double"/> value within the <paramref name="min"/> and <paramref name="max"/> bounds.</returns>
        public static double ClampToBounds(this double value, (double Min, double Max) bounds)
        {
            if (value > bounds.Max)
                return bounds.Max;
            if (value < bounds.Min)
                return bounds.Min;
            return value;
        }
        #endregion ClampToBounds

        #region Normalize
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="rangeMin">The current range's (inclusive) minimum boundary.</param>
        /// <param name="rangeMax">The current range's (inclusive) maximum boundary.</param>
        /// <param name="newRangeMin">The (inclusive) minimum boundary of the range to convert to.</param>
        /// <param name="newRangeMax">The (inclusive) maximum boundary of the range to convert to.</param>
        /// <returns>The <see cref="double"/> value, normalized from the specified current range to the specified new range.</returns>
        public static double Normalize(this double value, double rangeMin, double rangeMax, double newRangeMin, double newRangeMax)
        {
            return newRangeMin + (value - rangeMin) * (newRangeMax - newRangeMin) / (rangeMax - rangeMin);
        }
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="range">The current range's (inclusive) minimum and (inclusive) maximum boundaries.</param>
        /// <param name="newRange">The (inclusive) minimum and (inclusive) maximum boundaries of the range to convert to.</param>
        /// <returns>The <see cref="double"/> value, normalized from the specified <paramref name="range"/> to the specified <paramref name="newRange"/>.</returns>
        public static double Normalize(this double value, (double Min, double Max) range, (double Min, double Max) newRange)
        {
            return newRange.Min + (value - range.Min) * (newRange.Max - newRange.Min) / (range.Max - range.Min);
        }
        #endregion Normalize
    }
}
