using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace CSharpExt
{
    /// <summary>
    /// Provides extension methods for <see cref="Enum"/> types.
    /// </summary>
    public static class EnumExtensions
    {
        #region IsSingleFlag
        /// <summary>
        /// Checks if the current instance has exactly 0 or 1 bit set in its bit field.
        /// </summary>
        /// <typeparam name="T">An <see cref="Enum"/> type marked with the <see cref="FlagsAttribute"/>.</typeparam>
        /// <param name="value"/>
        /// <returns><see langword="true"/> when the enum has 0 or 1 bits set; otherwise, <see langword="false"/>.</returns>
        public static bool IsSingleFlag<T>(this T value) where T : struct, Enum
        {
            // convert to unsigned integer
            var flags_v = Convert.ToUInt64(value);

            // check if 0, or if exactly 1 bit is set
            return flags_v == 0
                || (flags_v & (flags_v - 1)) == 0;
        }
        #endregion IsSingleFlag

        #region EnumerateFlags
        /// <summary>
        /// Enumerates each single-bit <typeparamref name="T"/> value in the current instance.
        /// </summary>
        /// <typeparam name="T">An <see cref="Enum"/> type marked with the <see cref="FlagsAttribute"/>.</typeparam>
        /// <param name="value"/>
        /// <returns>Enumerable that contains each of the flags that were set; or 0 if no flags were set.</returns>
        public static IEnumerable<T> EnumerateFlags<T>(this T value) where T : struct, Enum
        {
            var flags_v = Convert.ToUInt64(value);
            if (flags_v != 0)
            {
                // enumerate the bits in the enum
                ulong bit = 0x1;
                for (int i = 0, bitCount = 8 * Marshal.SizeOf(Enum.GetUnderlyingType(typeof(T)));
                    i < bitCount;
                    ++i, bit = (ulong)(0x1 << i))
                {
                    if ((flags_v & bit) != 0)
                    {
                        yield return (T)Enum.ToObject(typeof(T), bit);
                    }
                }
            }
            else yield return (T)Enum.ToObject(typeof(T), 0);
        }
        #endregion EnumerateFlags

        #region ToSingleFlags
        /// <summary>
        /// Splits the current instance into an array of individual <typeparamref name="T"/> values.
        /// </summary>
        /// <typeparam name="T">An <see cref="Enum"/> type marked with the <see cref="FlagsAttribute"/>.</typeparam>
        /// <param name="value"/>
        /// <returns><typeparamref name="T"/> array of each set bit field value.</returns>
        public static T[] ToSingleFlags<T>(this T value) where T : struct, Enum
        {
            return EnumerateFlags(value).ToArray();
        }
        #endregion ToSingleFlags

        #region ToFlags
        /// <summary>
        /// Merges each of the values in the current instance into a single <see cref="Enum"/> value.
        /// </summary>
        /// <typeparam name="T">An <see cref="Enum"/> type marked with the <see cref="FlagsAttribute"/>.</typeparam>
        /// <param name="flags"/>
        /// <returns>Value with the bits specified by <paramref name="flags"/> set.</returns>
        public static T ToFlags<T>(this IEnumerable<T> flags) where T : struct, Enum
        {
            var result = Convert.ToUInt64(default(T));

            foreach (var value in flags)
            {
                result |= Convert.ToUInt64(value);
            }

            return (T)Enum.ToObject(typeof(T), result);
        }
        #endregion ToFlags

        #region HasAnyFlag
        /// <summary>
        /// Determines whether any one of the specified bit fields are set in the current instance.
        /// </summary>
        /// <typeparam name="T">An <see cref="Enum"/> type marked with the <see cref="FlagsAttribute"/>.</typeparam>
        /// <param name="value"/>
        /// <param name="flags">Any number of <typeparamref name="T"/> instances.</param>
        /// <returns><see langword="true"/> when any of the specified bit fields are set in the current instance; otherwise, <see langword="false"/>.</returns>
        public static bool HasAnyFlag<T>(this T value, IEnumerable<T> flags) where T : struct, Enum
        {
            foreach (T flag in flags)
            {
                if (value.HasFlag(flag)) return true;
            }
            return false;
        }
        /// <summary>
        /// Determines whether the current instance has any one of the specified <typeparamref name="T"/> values set.
        /// </summary>
        /// <typeparam name="T">An <see cref="Enum"/> type marked with the <see cref="FlagsAttribute"/>.</typeparam>
        /// <param name="value"/>
        /// <param name="flags">Any number of <typeparamref name="T"/> instances.</param>
        /// <returns><see langword="true"/> when any of the specified bit fields are set in the current instance; otherwise, <see langword="false"/>.</returns>
        public static bool HasAnyFlag<T>(this T value, params T[] flags) where T : struct, Enum
        {
            for (int i = 0, i_max = flags.Length; i < i_max; ++i)
            {
                if (value.HasFlag(flags[i])) return true;
            }
            return false;
        }
        #endregion HasAnyFlag

        #region EqualsAny
        /// <summary>
        /// Determines whether the current instance is equal to any one of the specified <typeparamref name="T"/> values.
        /// </summary>
        /// <typeparam name="T">An <see cref="Enum"/> type marked with the <see cref="FlagsAttribute"/>.</typeparam>
        /// <param name="value"/>
        /// <param name="flags">Any number of <typeparamref name="T"/> values to check.</param>
        /// <returns><see langword="true"/> when equal to at least one specified <typeparamref name="T"/> value; otherwise, <see langword="false"/>.</returns>
        public static bool EqualsAny<T>(this T value, IEnumerable<T> flags) where T : struct, Enum
        {
            foreach (var flag in flags)
            {
                if (value.Equals(flag)) return true;
            }
            return false;
        }
        /// <summary>
        /// Determines whether the current instance is equal to any one of the specified <typeparamref name="T"/> values.
        /// </summary>
        /// <typeparam name="T">An <see cref="Enum"/> type marked with the <see cref="FlagsAttribute"/>.</typeparam>
        /// <param name="value"/>
        /// <param name="flags">Any number of <typeparamref name="T"/> values to check.</param>
        /// <returns><see langword="true"/> when equal to at least one specified <typeparamref name="T"/> value; otherwise, <see langword="false"/>.</returns>
        public static bool EqualsAny<T>(this T value, params T[] flags) where T : struct, Enum
        {
            for (int i = 0, i_max = flags.Length; i < i_max; ++i)
            {
                if (value.Equals(flags[i])) return true;
            }
            return false;
        }
        #endregion EqualsAny
    }
}
