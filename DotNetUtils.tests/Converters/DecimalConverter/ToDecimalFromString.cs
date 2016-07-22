using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.DecimalConverter
{
    [TestFixture]
    public class ToDecimalFromString
    {
        [TestCase("1", 0, '.', ',', ExpectedResult = 1)]
        [TestCase("1.", 0, '.', ',', ExpectedResult = 1)]
        [TestCase("0.00", -1, '.', ',', ExpectedResult = 0)]
        [TestCase("0.01", -1, '.', ',', ExpectedResult = 0.01)]
        [TestCase("0.11", -1, '.', ',', ExpectedResult = 0.11)]
        [TestCase("1.11", 0, '.', ',', ExpectedResult = 1.11)]
        [TestCase("11.11", 0, '.', ',', ExpectedResult = 11.11)]
        [TestCase("111.11", 0, '.', ',', ExpectedResult = 111.11)]
        [TestCase("1,111.11", 0, '.', ',', ExpectedResult = 1111.11)]
        [TestCase("11,111.11", 0, '.', ',', ExpectedResult = 11111.11)]
        [TestCase("111,111.11", 0, '.', ',', ExpectedResult = 111111.11)]
        [TestCase("1,111,111.11", 0, '.', ',', ExpectedResult = 1111111.11)]
        [TestCase("1,111,111", 0, '.', ',', ExpectedResult = 1111111)]
        [TestCase("USD 1,111,111.11", 0, '.', ',', ExpectedResult = 1111111.11)]
        [TestCase("U$ 1,111,111.11", 0, '.', ',', ExpectedResult = 1111111.11)]
        [TestCase("100%", 0, '.', ',', ExpectedResult = 100)]
        [TestCase("99.99%", 0, '.', ',', ExpectedResult = 99.99)]
        [TestCase("123,456,789.12345678901234567890", 0, '.', ',', ExpectedResult = 123456789.12345678901234567890)]
        public decimal ToDecimal_FromStringValidNumbers(string stringValue, decimal defaultValue, char decimalSeparator, char milharSeparator)
        {
            return stringValue.ToDecimal(defaultValue, decimalSeparator, milharSeparator);
        }

        [TestCase("", -1, '.', ',', ExpectedResult = -1)]
        [TestCase("R$", -1, '.', ',', ExpectedResult = -1)]
        [TestCase("ABC", -1, '.', ',', ExpectedResult = -1)]
        [TestCase(null, -1, '.', ',', ExpectedResult = -1)]
        public decimal ToDecimal_FromStringInvalidNumbers(string stringValue, decimal defaultValue, char decimalSeparator, char milharSeparator)
        {
            return stringValue.ToDecimal(defaultValue, decimalSeparator, milharSeparator);
        }

        [TestCase("0", 0, '.', ',', ExpectedResult = 0)]
        [TestCase("0.01", 0, '.', ',', ExpectedResult = 0.01)]
        [TestCase("0.11", 0, '.', ',', ExpectedResult = 0.11)]
        [TestCase("1", 0, '.', ',', ExpectedResult = 1)]
        [TestCase("1.", 0, '.', ',', ExpectedResult = 1)]
        [TestCase("1,11", 0, ',', '.', ExpectedResult = 1.11)]
        [TestCase("11,11", 0, ',', '.', ExpectedResult = 11.11)]
        [TestCase("111,11", 0, ',', '.', ExpectedResult = 111.11)]
        [TestCase("1.111,11", 0, ',', '.', ExpectedResult = 1111.11)]
        [TestCase("11.111,11", 0, ',', '.', ExpectedResult = 11111.11)]
        [TestCase("111.111,11", 0, ',', '.', ExpectedResult = 111111.11)]
        [TestCase("1.111.111,11", 0, ',', '.', ExpectedResult = 1111111.11)]
        public decimal ToDecimal_FromStringDifferentSeparators(string stringValue, decimal defaultValue, char decimalSeparator, char milharSeparator)
        {
            return stringValue.ToDecimal(defaultValue, decimalSeparator, milharSeparator);
        }

        [TestCase("0.00", ExpectedResult = 0)]
        [TestCase("0.01", ExpectedResult = 0.01)]
        [TestCase("0.11", ExpectedResult = 0.11)]
        [TestCase("1.11", ExpectedResult = 1.11)]
        [TestCase("11.11", ExpectedResult = 11.11)]
        [TestCase("111.11", ExpectedResult = 111.11)]
        [TestCase("1,111.11", ExpectedResult = 1111.11)]
        [TestCase("11,111.11", ExpectedResult = 11111.11)]
        [TestCase("111,111.11", ExpectedResult = 111111.11)]
        [TestCase("1,111,111.11", ExpectedResult = 1111111.11)]
        [TestCase("USD 1,111,111.11", ExpectedResult = 1111111.11)]
        [TestCase("U$ 1,111,111.11", ExpectedResult = 1111111.11)]
        [TestCase("100%", ExpectedResult = 100)]
        [TestCase("99.99%", ExpectedResult = 99.99)]
        [TestCase("", ExpectedResult = 0)]
        [TestCase("R$", ExpectedResult = 0)]
        [TestCase("ABC", ExpectedResult = 0)]
        [TestCase(null, ExpectedResult = 0)]
        public decimal ToDecimal_FromStringWithoutDefaults(string stringValue)
        {
            return stringValue.ToDecimal();
        }
    }
}
