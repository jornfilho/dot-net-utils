using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DotNetUtils.Converters
{
    /// <summary>
    /// Byte converter extension
    /// </summary>
    public static class ByteConverterExtension
    {
        /// <summary>
        /// Convert string in byte value
        /// </summary>
        /// <param name="stringValue">String value</param>
        /// <param name="defaultValue">Default byte value. Default is 0</param>
        /// <param name="decimalSeparator">Decimal separator. Default is .</param>
        /// <param name="milharSeparator">Milhar separator. Default is ,</param>
        public static byte ToByte(this string stringValue, byte defaultValue = 0, char decimalSeparator = '.', char milharSeparator = ',')
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

            byte parsedByte;
            return byte.TryParse(stringValue, out parsedByte) ? parsedByte : defaultValue;
        }

        /// <summary>
        /// Convert long value to byte value
        /// </summary>
        /// <param name="longValue">Long value</param>
        /// <param name="defaultValue">Default byte value. Default is 0</param>
        public static byte ToByte(this long longValue, byte defaultValue = 0)
        {
            if (longValue > byte.MaxValue || longValue < byte.MinValue)
                return defaultValue;

            return (byte)longValue;
        }

        /// <summary>
        /// Convert nullable long value to byte value
        /// </summary>
        /// <param name="longValue">Nullable long value</param>
        /// <param name="defaultValue">Default byte value. Default is 0</param>
        public static byte ToByte(this long? longValue, byte defaultValue = 0)
        {
            return longValue == null ? defaultValue : longValue.Value.ToByte(defaultValue);
        }

        /// <summary>
        /// Convert int value to byte value
        /// </summary>
        /// <param name="intValue">Integer value</param>
        /// <param name="defaultValue">Default byte value. Default is 0</param>
        public static byte ToByte(this int intValue, byte defaultValue = 0)
        {
            if (intValue >= byte.MaxValue || intValue <= byte.MinValue)
                return defaultValue;

            return (byte)intValue;
        }

        /// <summary>
        /// Convert nullable int value to byte value
        /// </summary>
        /// <param name="intValue">Nullable byte value</param>
        /// <param name="defaultValue">Default byte value. Default is 0</param>
        public static byte ToByte(this int? intValue, byte defaultValue = 0)
        {
            return intValue == null ? defaultValue : intValue.Value.ToByte(defaultValue);
        }

        /// <summary>
        /// Convert decimal value to byte value
        /// </summary>
        /// <param name="decimalValue">Decimal value</param>
        /// <param name="defaultValue">Default byte value. Default is 0</param>
        public static byte ToByte(this decimal decimalValue, byte defaultValue = 0)
        {
            if (decimalValue > byte.MaxValue || decimalValue <= byte.MinValue)
                return defaultValue;

            return (byte)decimalValue;
        }

        /// <summary>
        /// Convert nullable decimal value to byte value
        /// </summary>
        /// <param name="decimalValue">Nullable decimal value</param>
        /// <param name="defaultValue">Default byte value. Default is 0</param>
        public static byte ToByte(this decimal? decimalValue, byte defaultValue = 0)
        {
            return decimalValue == null ? defaultValue : ToByte(decimalValue.Value, defaultValue);
        }

        /// <summary>
        /// Convert double value to byte value
        /// </summary>
        /// <param name="doubleValue">Double value</param>
        /// <param name="defaultValue">Default byte value. Default is 0</param>
        public static byte ToByte(this double doubleValue, byte defaultValue = 0)
        {
            if (doubleValue > byte.MaxValue || doubleValue <= byte.MinValue)
                return defaultValue;

            var decimalValue = Convert.ToDecimal(doubleValue);
            if (decimalValue > byte.MaxValue || decimalValue <= byte.MinValue)
                return defaultValue;

            return (byte)decimalValue;
        }

        /// <summary>
        /// Convert nullable double value to byte value
        /// </summary>
        /// <param name="doubleValue">Nullable double value</param>
        /// <param name="defaultValue">Default byte value. Default is 0</param>
        public static byte ToByte(this double? doubleValue, byte defaultValue = 0)
        {
            return doubleValue == null ? defaultValue : doubleValue.Value.ToByte(defaultValue);
        }

        /// <summary>
        /// Convert float value to byte value
        /// </summary>
        /// <param name="floatValue">Float value</param>
        /// <param name="defaultValue">Default byte value. Default is 0</param>
        public static byte ToByte(this float floatValue, byte defaultValue = 0)
        {
            if (floatValue > byte.MaxValue || floatValue <= byte.MinValue)
                return defaultValue;

            var decimalValue = Convert.ToDecimal(floatValue);
            if (decimalValue > byte.MaxValue || decimalValue <= byte.MinValue)
                return defaultValue;

            return (byte)decimalValue;
        }

        /// <summary>
        /// Convert nullable float value to byte value
        /// </summary>
        /// <param name="floatValue">Nullable float value</param>
        /// <param name="defaultValue">Default byte value. Default is 0</param>
        public static byte ToByte(this float? floatValue, byte defaultValue = 0)
        {
            return floatValue == null ? defaultValue : floatValue.Value.ToByte(defaultValue);
        }

        /// <summary>
        /// Convert short value to byte value
        /// </summary>
        /// <param name="shortValue">Short value</param>
        /// <param name="defaultValue">Default byte value. Default is 0</param>
        public static byte ToByte(this short shortValue, byte defaultValue = 0)
        {
            if (shortValue > byte.MaxValue || shortValue < byte.MinValue)
                return defaultValue;

            return (byte)shortValue;
        }

        /// <summary>
        /// Convert nullable short value to byte value
        /// </summary>
        /// <param name="shortValue">Nullable short value</param>
        /// <param name="defaultValue">Default byte value. Default is 0</param>
        public static byte ToByte(this short? shortValue, byte defaultValue = 0)
        {
            return shortValue == null ? defaultValue : shortValue.Value.ToByte(defaultValue);
        }
    }
}