using System.Linq;
using System.Text.RegularExpressions;

namespace DotNetUtils.Converters
{
    /// <summary>
    /// Integer converter interface
    /// </summary>
    public static class IntegerConverter
    {
        /// <summary>
        /// Convert string in integer value
        /// </summary>
        /// <param name="stringValue">String value</param>
        /// <param name="defaultValue">Default integer value. Default is 0</param>
        /// <param name="decimalSeparator">Decimal separator. Default is .</param>
        /// <param name="milharSeparator">Milhar separator. Default is ,</param>
        public static int ToInteger(this string stringValue, int defaultValue = 0, char decimalSeparator = '.', char milharSeparator = ',')
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

            int parsedInt;
            if (int.TryParse(stringValue, out parsedInt))
                defaultValue = parsedInt;

            return defaultValue;
        }

        /// <summary>
        /// Convert long value to integer value
        /// </summary>
        /// <param name="longValue">Long value</param>
        /// <param name="defaultValue">Default integer value. Default is 0</param>
        public static int ToInteger(this long longValue, int defaultValue = 0)
        {
            if (longValue > int.MaxValue || longValue < int.MinValue)
                return defaultValue;

            return (int)longValue;
        }

        /// <summary>
        /// Convert nullable long value to integer value
        /// </summary>
        /// <param name="longValue">Nullable long value</param>
        /// <param name="defaultValue">Default integer value. Default is 0</param>
        public static int ToInteger(this long? longValue, int defaultValue = 0)
        {
            return longValue == null ? defaultValue : longValue.Value.ToInteger(defaultValue);
        }

        /// <summary>
        /// Convert decimal value to integer value
        /// </summary>
        /// <param name="decimalValue">Decimal value</param>
        /// <param name="defaultValue">Default integer value. Default is 0</param>
        public static int ToInteger(this decimal decimalValue, int defaultValue = 0)
        {
            if (decimalValue > int.MaxValue || decimalValue <= int.MinValue)
                return defaultValue;

            return (int)decimalValue;
        }

        /// <summary>
        /// Convert nullable decimal value to integer value
        /// </summary>
        /// <param name="decimalValue">Nullable decimal value</param>
        /// <param name="defaultValue">Default integer value. Default is 0</param>
        public static int ToInteger(this decimal? decimalValue, int defaultValue = 0)
        {
            return decimalValue == null ? defaultValue : decimalValue.Value.ToInteger(defaultValue);
        }

        /// <summary>
        /// Convert double value to integer value
        /// </summary>
        /// <param name="doubleValue">Double value</param>
        /// <param name="defaultValue">Default integer value. Default is 0</param>
        public static int ToInteger(this double doubleValue, int defaultValue = 0)
        {
            if (doubleValue > int.MaxValue || doubleValue <= int.MinValue)
                return defaultValue;

            return (int)doubleValue;
        }

        /// <summary>
        /// Convert nullable double value to integer value
        /// </summary>
        /// <param name="doubleValue">Nullable double value</param>
        /// <param name="defaultValue">Default integer value. Default is 0</param>
        public static int ToInteger(this double? doubleValue, int defaultValue = 0)
        {
            if (doubleValue == null)
                return defaultValue;

            return doubleValue.Value.ToInteger(defaultValue);
        }

        /// <summary>
        /// Convert float value to integer value
        /// </summary>
        /// <param name="floatValue">Float value</param>
        /// <param name="defaultValue">Default integer value. Default is 0</param>
        public static int ToInteger(this float floatValue, int defaultValue = 0)
        {
            if (floatValue > int.MaxValue || floatValue <= int.MinValue)
                return defaultValue;

            return (int)floatValue;
        }

        /// <summary>
        /// Convert nullable float value to integer value
        /// </summary>
        /// <param name="floatValue">Nullable float value</param>
        /// <param name="defaultValue">Default integer value. Default is 0</param>
        public static int ToInteger(this float? floatValue, int defaultValue = 0)
        {
            return floatValue == null ? defaultValue : floatValue.Value.ToInteger(defaultValue);
        }

        /// <summary>
        /// Convert short value to integer value
        /// </summary>
        /// <param name="shortValue">Short value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        public static int ToInteger(this short shortValue, int defaultValue = 0)
        {
            return shortValue;
        }

        /// <summary>
        /// Convert nullable short value to integer value
        /// </summary>
        /// <param name="shortValue">Nullable short value</param>
        /// <param name="defaultValue">Default short value. Default is 0</param>
        public static int ToInteger(this short? shortValue, int defaultValue = 0)
        {
            return shortValue == null ? defaultValue : shortValue.Value.ToInteger(defaultValue);
        }

        /// <summary>
        /// Convert byte value to integer value
        /// </summary>
        /// <param name="byteValue">Byte value</param>
        /// <param name="defaultValue">Default integer value. Default is 0</param>
        public static int ToInteger(this byte byteValue, int defaultValue = 0)
        {
            return byteValue;
        }

        /// <summary>
        /// Convert nullable byte value to integer value
        /// </summary>
        /// <param name="byteValue">Nullable byte value</param>
        /// <param name="defaultValue">Default integer value. Default is 0</param>
        public static int ToInteger(this byte? byteValue, int defaultValue = 0)
        {
            return byteValue == null ? defaultValue : byteValue.Value.ToInteger(defaultValue);
        }
    }
}