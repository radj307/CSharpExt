using System;

namespace CSharpExt
{
    /// <summary>
    /// Provides extension methods for the <see cref="float"/> type.
    /// </summary>
    public static class SingleExtensions
    {
        #region Constant Fields
        /// <summary>
        /// Maximum difference between two equal <see cref="float"/> numbers.
        /// </summary>
        public const float Epsilon = 1E-09f;
        #endregion Constant Fields

        #region EqualsWithin (float, float)
        /// <summary>
        /// Checks if the specified <see cref="float"/> values are equal, within the specified deviation.
        /// </summary>
        /// <param name="l"/>
        /// <param name="r">A <see cref="float"/> to check equality with.</param>
        /// <param name="within">The maximum difference between the float values that can be considered equal.</param>
        /// <returns><see langword="true"/> when equal; otherwise, <see langword="false"/>.</returns>
        public static bool EqualsWithin(this float l, float r, float within = Epsilon)
        {
            return (float.IsInfinity(l) && float.IsInfinity(r))
                || (float.IsNaN(l) && float.IsNaN(r))
                || Math.Abs(l - r) < within;
        }
        /// <summary>
        /// Checks if the specified <see cref="float"/> values are equal, within the specified deviation.
        /// </summary>
        /// <param name="l"/>
        /// <param name="r">A <see cref="float"/> to check equality with.</param>
        /// <param name="within">The maximum difference between the float values that can be considered equal.</param>
        /// <returns><see langword="true"/> when equal; otherwise, <see langword="false"/>.</returns>
        public static bool EqualsWithin(this float? l, float? r, float within = Epsilon)
        {
            bool lHasValue = l.HasValue;
            bool rHasValue = r.HasValue;
            if (!lHasValue || !rHasValue)
            {
                return lHasValue == rHasValue;
            }

            return (float.IsInfinity(l.Value) && float.IsInfinity(r.Value))
                || (float.IsNaN(l.Value) && float.IsNaN(r.Value))
                || Math.Abs(l.Value - r.Value) < within;
        }
        #endregion EqualsWithin (float, float)

        #region EqualsWithin (float, double)
        /// <summary>
        /// Checks if the specified <see cref="float"/> value &amp; <see cref="double"/> value are equal, within the specified deviation.
        /// </summary>
        /// <param name="l"/>
        /// <param name="r">A <see cref="double"/> to check equality with.</param>
        /// <param name="within">The maximum difference between the float values that can be considered equal.</param>
        /// <returns><see langword="true"/> when equal; otherwise, <see langword="false"/>.</returns>
        public static bool EqualsWithin(this float l, double r, float within = Epsilon)
        {
            return (float.IsInfinity(l) && double.IsInfinity(r))
                || (float.IsNaN(l) && double.IsNaN(r))
                || Math.Abs(l - r) < within;
        }
        /// <summary>
        /// Checks if the specified <see cref="float"/> value &amp; <see cref="double"/> value are equal, within the specified deviation.
        /// </summary>
        /// <param name="l"/>
        /// <param name="r">A <see cref="double"/> to check equality with.</param>
        /// <param name="within">The maximum difference between the float values that can be considered equal.</param>
        /// <returns><see langword="true"/> when equal; otherwise, <see langword="false"/>.</returns>
        public static bool EqualsWithin(this float? l, double? r, float within = Epsilon)
        {
            bool lHasValue = l.HasValue;
            bool rHasValue = r.HasValue;
            if (!lHasValue || !rHasValue)
            {
                return lHasValue == rHasValue;
            }

            return (float.IsInfinity(l.Value) && double.IsInfinity(r.Value))
                || (float.IsNaN(l.Value) && double.IsNaN(r.Value))
                || Math.Abs(l.Value - r.Value) < within;
        }
        #endregion EqualsWithin (float, double)

        #region ClampToBounds
        /// <summary>
        /// Clamps the <see cref="float"/> value within the specified <paramref name="min"/> and <paramref name="max"/> boundaries.
        /// </summary>
        /// <param name="value"/>
        /// <param name="min">The (inclusive) minimum boundary value.</param>
        /// <param name="max">The (inclusive) maximum boundary value.</param>
        /// <returns>A <see cref="float"/> value within the <paramref name="min"/> and <paramref name="max"/> bounds.</returns>
        public static float ClampToBounds(this float value, float min, float max)
        {
            if (value > max)
                return max;
            if (value < min)
                return min;
            return value;
        }
        /// <summary>
        /// Clamps the <see cref="float"/> value within the specified <paramref name="bounds"/>.
        /// </summary>
        /// <param name="value"/>
        /// <param name="bounds">The (inclusive) minimum and (inclusive) maximum boundary values.</param>
        /// <returns>A <see cref="float"/> value within the <paramref name="min"/> and <paramref name="max"/> bounds.</returns>
        public static float ClampToBounds(this float value, (float Min, float Max) bounds)
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
        /// <returns>The <see cref="float"/> value, normalized from the specified current range to the specified new range.</returns>
        public static float Normalize(this float value, float rangeMin, float rangeMax, float newRangeMin, float newRangeMax)
        {
            return newRangeMin + (value - rangeMin) * (newRangeMax - newRangeMin) / (rangeMax - rangeMin);
        }
        /// <summary>
        /// Converts the value to the specified range by scaling it.
        /// </summary>
        /// <param name="value"/>
        /// <param name="range">The current range's (inclusive) minimum and (inclusive) maximum boundaries.</param>
        /// <param name="newRange">The (inclusive) minimum and (inclusive) maximum boundaries of the range to convert to.</param>
        /// <returns>The <see cref="float"/> value, normalized from the specified <paramref name="range"/> to the specified <paramref name="newRange"/>.</returns>
        public static float Normalize(this float value, (float Min, float Max) range, (float Min, float Max) newRange)
        {
            return newRange.Min + (value - range.Min) * (newRange.Max - newRange.Min) / (range.Max - range.Min);
        }
        #endregion Normalize
    }
}
