using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace DotNetUtils.Converters
{
    /// <summary>
    /// Decimal converter extension
    /// </summary>
    public static class DecimalConverterExtension
    {
        /// <summary>
        /// Convert string in decimal value
        /// </summary>
        /// <param name="stringValue">String value</param>
        /// <param name="defaultValue">Default decimal value. Default is 0</param>
        /// <param name="decimalSeparator">Decimal separator. Default is .</param>
        /// <param name="milharSeparator">Milhar separator. Default is ,</param>
        public static decimal ToDecimal(this string stringValue, decimal defaultValue = 0, char decimalSeparator = '.', char milharSeparator = ',')
        {
            if (string.IsNullOrEmpty(stringValue))
                return defaultValue;

            Regex allowedCharacters = new Regex("[^0-9.,]");
            stringValue = allowedCharacters.Replace(stringValue, "");

            if (string.IsNullOrEmpty(stringValue))
                return defaultValue;

            stringValue = stringValue.Replace(milharSeparator.ToString(), "");

            string integerSection = stringValue, 
                decimalSection = "0";

            var splittedResult = stringValue.Split(decimalSeparator);
            if (splittedResult.Length > 1)
            {
                decimalSection = splittedResult.LastOrDefault();
                if (!string.IsNullOrEmpty(decimalSection))
                    integerSection = integerSection.Substring(0, integerSection.Length - decimalSection.Length);
                else
                    decimalSection = "0";

                integerSection = integerSection.Replace(decimalSeparator.ToString(), "");
                decimalSection = decimalSection.Replace(decimalSeparator.ToString(), "");
            }
            
            var culture = CultureInfo.CurrentCulture;
            var decimalStrValue = string.Format("{0}{1}{2}", integerSection, culture.NumberFormat.CurrencyDecimalSeparator, decimalSection);

            decimal parsedDecimal;
            return decimal.TryParse(decimalStrValue, NumberStyles.Float, culture, out parsedDecimal)
                ? parsedDecimal
                : defaultValue;
        }

        /// <summary>
        /// Convert long value to decimal value
        /// </summary>
        /// <param name="longValue">Long value</param>
        public static decimal ToDecimal(this long longValue)
        {
            return longValue;
        }

        /// <summary>
        /// Convert nullable long value to decimal value
        /// </summary>
        /// <param name="longValue">Nullable long value</param>
        /// <param name="defaultValue">Default decimal value. Default is 0</param>
        public static decimal ToDecimal(this long? longValue, decimal defaultValue = 0)
        {
            return longValue == null ? defaultValue : longValue.Value.ToDecimal();
        }

        /// <summary>
        /// Convert int value to decimal value
        /// </summary>
        /// <param name="intValue">Integer value</param>
        public static decimal ToDecimal(this int intValue)
        {
            return intValue;
        }

        /// <summary>
        /// Convert nullable int value to decimal value
        /// </summary>
        /// <param name="intValue">Nullable int value</param>
        /// <param name="defaultValue">Default decimal value. Default is 0</param>
        public static decimal ToDecimal(this int? intValue, decimal defaultValue = 0)
        {
            return intValue == null ? defaultValue : intValue.Value.ToDecimal();
        }

        /// <summary>
        /// Convert double value to decimal value
        /// </summary>
        /// <param name="doubleValue">Double value</param>
        /// <param name="defaultValue">Default decimal value. Default is 0</param>
        public static decimal ToDecimal(this double doubleValue, decimal defaultValue = 0)
        {
            if (doubleValue > (double) decimal.MaxValue || doubleValue < (double) decimal.MinValue)
                return defaultValue;

            return decimal.Parse(doubleValue.ToString("R"),
                NumberStyles.AllowExponent |
                NumberStyles.AllowDecimalPoint |
                NumberStyles.AllowLeadingSign |
                NumberStyles.AllowTrailingSign);
        }

        /// <summary>
        /// Convert nullable double value to decimal value
        /// </summary>
        /// <param name="doubleValue">Nullable double value</param>
        /// <param name="defaultValue">Default decimal value. Default is 0</param>
        public static decimal ToDecimal(this double? doubleValue, decimal defaultValue = 0)
        {
            return doubleValue == null ? defaultValue : doubleValue.Value.ToDecimal(defaultValue);
        }

        /// <summary>
        /// Convert float value to decimal value
        /// </summary>
        /// <param name="floatValue">Float value</param>
        /// <param name="defaultValue">Default decimal value. Default is 0</param>
        public static decimal ToDecimal(this float floatValue, decimal defaultValue = 0)
        {
            if (floatValue > (double)decimal.MaxValue || floatValue < (double)decimal.MinValue)
                return defaultValue;

            return decimal.Parse(floatValue.ToString("R"),
                NumberStyles.AllowExponent |
                NumberStyles.AllowDecimalPoint |
                NumberStyles.AllowLeadingSign |
                NumberStyles.AllowTrailingSign);
        }

        /// <summary>
        /// Convert nullable float value to decimal value
        /// </summary>
        /// <param name="floatValue">Nullable float value</param>
        /// <param name="defaultValue">Default decimal value. Default is 0</param>
        public static decimal ToDecimal(this float? floatValue, decimal defaultValue = 0)
        {
            return floatValue == null ? defaultValue : floatValue.Value.ToDecimal(defaultValue);
        }

        /// <summary>
        /// Convert short value to decimal value
        /// </summary>
        /// <param name="shortValue">Short value</param>
        public static decimal ToDecimal(this short shortValue)
        {
            return shortValue;
        }

        /// <summary>
        /// Convert nullable short value to decimal value
        /// </summary>
        /// <param name="shortValue">Nullable short value</param>
        /// <param name="defaultValue">Default decimal value. Default is 0</param>
        public static decimal ToDecimal(this short? shortValue, decimal defaultValue = 0)
        {
            return shortValue == null ? defaultValue : shortValue.Value.ToDecimal();
        }

        /// <summary>
        /// Convert byte value to decimal value
        /// </summary>
        /// <param name="byteValue">Byte value</param>
        public static decimal ToDecimal(this byte byteValue)
        {
            return byteValue;
        }

        /// <summary>
        /// Convert nullable byte value to decimal value
        /// </summary>
        /// <param name="byteValue">Nullable byte value</param>
        /// <param name="defaultValue">Default decimal value. Default is 0</param>
        public static decimal ToDecimal(this byte? byteValue, decimal defaultValue = 0)
        {
            return byteValue == null ? defaultValue : byteValue.Value.ToDecimal();
        }
    }
}