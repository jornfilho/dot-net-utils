using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DotNetUtils.Converters
{
    /// <summary>
    /// Long converter extension class
    /// </summary>
    public static class LongConverterExtension
    {
        /// <summary>
        /// Convert string in long value
        /// </summary>
        /// <param name="stringValue">String value</param>
        /// <param name="defaultValue">Default long value. Default is 0</param>
        /// <param name="decimalSeparator">Decimal separator. Default is .</param>
        /// <param name="milharSeparator">Milhar separator. Default is ,</param>
        public static long ToLong(this string stringValue, long defaultValue = 0, char decimalSeparator = '.', char milharSeparator = ',')
        {
            if (string.IsNullOrEmpty(stringValue))
                return defaultValue;

            Regex allowedCharacters = new Regex("[^0-9.,]");
            stringValue = allowedCharacters.Replace(stringValue, "");

            if (string.IsNullOrEmpty(stringValue))
                return defaultValue;

            stringValue = stringValue.Replace(milharSeparator.ToString(), "");

            var splittedResult = stringValue.Split(decimalSeparator);
            if (splittedResult.Length > 1)
            {
                var decimalSection = splittedResult.LastOrDefault();
                if (decimalSection != null)
                    stringValue = stringValue.Substring(0, stringValue.Length - decimalSection.Length);

                stringValue = stringValue.Replace(decimalSeparator.ToString(), "");
            }

            long parsedLong;
            if (long.TryParse(stringValue, out parsedLong))
                defaultValue = parsedLong;

            return defaultValue;
        }

        /// <summary>
        /// Convert int value to long value
        /// </summary>
        /// <param name="intValue">Integer value</param>
        public static long ToLong(this int intValue)
        {
            return intValue;
        }

        /// <summary>
        /// Convert nullable int value to long value
        /// </summary>
        /// <param name="intValue">Nullable integer value</param>
        /// <param name="defaultValue">Default long value. Default is 0</param>
        public static long ToLong(this int? intValue, long defaultValue = 0)
        {
            return intValue == null ? defaultValue : intValue.Value.ToLong();
        }

        /// <summary>
        /// Convert decimal value to long value
        /// </summary>
        /// <param name="decimalValue">Decimal value</param>
        /// <param name="defaultValue">Default long value. Default is 0</param>
        public static long ToLong(this decimal decimalValue, long defaultValue = 0)
        {
            if (decimalValue > long.MaxValue || decimalValue <= long.MinValue)
                return defaultValue;

            return (long)decimalValue;
        }

        /// <summary>
        /// Convert nullable decimal value to long value
        /// </summary>
        /// <param name="decimalValue">Nullable decimal value</param>
        /// <param name="defaultValue">Default long value. Default is 0</param>
        public static long ToLong(this decimal? decimalValue, long defaultValue = 0)
        {
            return decimalValue == null ? defaultValue : decimalValue.Value.ToLong(defaultValue);
        }

        /// <summary>
        /// Convert double value to long value
        /// </summary>
        /// <param name="doubleValue">Double value</param>
        /// <param name="defaultValue">Default long value. Default is 0</param>
        public static long ToLong(this double doubleValue, long defaultValue = 0)
        {
            if (doubleValue > long.MaxValue || doubleValue <= long.MinValue)
                return defaultValue;

            return (long)Convert.ToDecimal(doubleValue);
        }

        /// <summary>
        /// Convert nullable double value to long value
        /// </summary>
        /// <param name="doubleValue">Nullable double value</param>
        /// <param name="defaultValue">Default long value. Default is 0</param>
        public static long ToLong(this double? doubleValue, long defaultValue = 0)
        {
            return doubleValue == null ? defaultValue : doubleValue.Value.ToLong(defaultValue);
        }

        /// <summary>
        /// Convert float value to long value
        /// </summary>
        /// <param name="floatValue">Float value</param>
        /// <param name="defaultValue">Default long value. Default is 0</param>
        public static long ToLong(this float floatValue, long defaultValue = 0)
        {
            if (floatValue > long.MaxValue || floatValue <= long.MinValue)
                return defaultValue;

            return (long)Convert.ToDecimal(floatValue);
        }

        /// <summary>
        /// Convert nullable float value to long value
        /// </summary>
        /// <param name="floatValue">Nullable float value</param>
        /// <param name="defaultValue">Default long value. Default is 0</param>
        public static long ToLong(this float? floatValue, long defaultValue = 0)
        {
            return floatValue == null ? defaultValue : floatValue.Value.ToLong(defaultValue);
        }

        /// <summary>
        /// Convert short value to long value
        /// </summary>
        /// <param name="shortValue">Short value</param>
        public static long ToLong(this short shortValue)
        {
            return shortValue;
        }

        /// <summary>
        /// Convert nullable short value to long value
        /// </summary>
        /// <param name="shortValue">Nullable short value</param>
        /// <param name="defaultValue">Default long value. Default is 0</param>
        public static long ToLong(this short? shortValue, long defaultValue = 0)
        {
            return shortValue == null ? defaultValue : shortValue.Value.ToLong();
        }

        /// <summary>
        /// Convert byte value to long value
        /// </summary>
        /// <param name="byteValue">Byte value</param>
        public static long ToLong(this byte byteValue)
        {
            return byteValue;
        }

        /// <summary>
        /// Convert nullable byte value to long value
        /// </summary>
        /// <param name="byteValue">Nullable byte value</param>
        /// <param name="defaultValue">Default long value. Default is 0</param>
        public static long ToLong(this byte? byteValue, long defaultValue = 0)
        {
            return byteValue == null ? defaultValue : byteValue.Value.ToLong();
        }
    }
}