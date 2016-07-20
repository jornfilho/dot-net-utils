using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DotNetUtils.Converters
{
    /// <summary>
    /// Short converter extension
    /// </summary>
    public static class ShortConverterExtension
    {
        /// <summary>
        /// Convert string in short value
        /// </summary>
        /// <param name="stringValue">String value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        /// <param name="decimalSeparator">Decimal separator. Default is .</param>
        /// <param name="milharSeparator">Milhar separator. Default is ,</param>
        public static short ToShort(this string stringValue, short defaultValue = 0, char decimalSeparator = '.', char milharSeparator = ',')
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

            short parsedShort;
            if (short.TryParse(stringValue, out parsedShort))
                defaultValue = parsedShort;

            return defaultValue;
        }

        /// <summary>
        /// Convert long value to short value
        /// </summary>
        /// <param name="longValue">Long value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        public static short ToShort(this long longValue, short defaultValue = 0)
        {
            if (longValue > short.MaxValue || longValue < short.MinValue)
                return defaultValue;

            return (short)longValue;
        }

        /// <summary>
        /// Convert nullable long value to short value
        /// </summary>
        /// <param name="longValue">Nullable long value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        public static short ToShort(this long? longValue, short defaultValue = 0)
        {
            return longValue == null ? defaultValue : longValue.Value.ToShort(defaultValue);
        }

        /// <summary>
        /// Convert int value to short value
        /// </summary>
        /// <param name="intValue">Integer value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        public static short ToShort(this int intValue, short defaultValue = 0)
        {
            if (intValue >= short.MaxValue || intValue <= short.MinValue)
                return defaultValue;

            return (short)intValue;
        }

        /// <summary>
        /// Convert nullable int value to short value
        /// </summary>
        /// <param name="intValue">Nullable short value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        public static short ToShort(this int? intValue, short defaultValue = 0)
        {
            return intValue == null ? defaultValue : intValue.Value.ToShort(defaultValue);
        }

        /// <summary>
        /// Convert decimal value to short value
        /// </summary>
        /// <param name="decimalValue">Decimal value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        public static short ToShort(this decimal decimalValue, short defaultValue = 0)
        {
            if (decimalValue > short.MaxValue || decimalValue <= short.MinValue)
                return defaultValue;

            return (short)decimalValue;
        }

        /// <summary>
        /// Convert nullable decimal value to short value
        /// </summary>
        /// <param name="decimalValue">Nullable decimal value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        public static short ToShort(this decimal? decimalValue, short defaultValue = 0)
        {
            return decimalValue == null ? defaultValue : decimalValue.Value.ToShort(defaultValue);
        }

        /// <summary>
        /// Convert double value to short value
        /// </summary>
        /// <param name="doubleValue">Double value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        public static short ToShort(this double doubleValue, short defaultValue = 0)
        {
            if (doubleValue > short.MaxValue || doubleValue <= short.MinValue)
                return defaultValue;

            var decimalValue = Convert.ToDecimal(doubleValue);
            if (decimalValue > short.MaxValue || decimalValue <= short.MinValue)
                return defaultValue;

            return (short)decimalValue;
        }

        /// <summary>
        /// Convert nullable double value to short value
        /// </summary>
        /// <param name="doubleValue">Nullable double value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        public static short ToShort(this double? doubleValue, short defaultValue = 0)
        {
            return doubleValue == null ? defaultValue : doubleValue.Value.ToShort(defaultValue);
        }

        /// <summary>
        /// Convert float value to short value
        /// </summary>
        /// <param name="floatValue">Float value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        public static short ToShort(this float floatValue, short defaultValue = 0)
        {
            if (floatValue > short.MaxValue || floatValue <= short.MinValue)
                return defaultValue;

            var decimalValue = Convert.ToDecimal(floatValue);
            if (decimalValue > short.MaxValue || decimalValue <= short.MinValue)
                return defaultValue;

            return (short)decimalValue;
        }

        /// <summary>
        /// Convert nullable float value to short value
        /// </summary>
        /// <param name="floatValue">Nullable float value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        public static short ToShort(this float? floatValue, short defaultValue = 0)
        {
            return floatValue == null ? defaultValue : floatValue.Value.ToShort(defaultValue);
        }

        /// <summary>
        /// Convert byte value to short value
        /// </summary>
        /// <param name="byteValue">Byte value</param>
        public static short ToShort(this byte byteValue)
        {
            return byteValue;
        }

        /// <summary>
        /// Convert nullable byte value to short value
        /// </summary>
        /// <param name="byteValue">Nullable byte value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        public static short ToShort(this byte? byteValue, short defaultValue = 0)
        {
            return byteValue == null ? defaultValue : byteValue.Value.ToShort();
        }
    }
}