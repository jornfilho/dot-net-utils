using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.ByteConverter
{
    [TestFixture]
    public class ToByteFromString
    {
        [TestCase("1", 0, '.', ',', ExpectedResult = 1)]
        [TestCase("1.", 0, '.', ',', ExpectedResult = 1)]
        [TestCase("0.00", 1, '.', ',', ExpectedResult = 0)]
        [TestCase("0.01", 1, '.', ',', ExpectedResult = 0)]
        [TestCase("0.11", 1, '.', ',', ExpectedResult = 0)]
        [TestCase("1.11", 0, '.', ',', ExpectedResult = 1)]
        [TestCase("11.11", 0, '.', ',', ExpectedResult = 11)]
        [TestCase("111.11", 0, '.', ',', ExpectedResult = 111)]
        [TestCase("1,111.11", 0, '.', ',', ExpectedResult = 0)]
        [TestCase("11,111.11", 0, '.', ',', ExpectedResult = 0)]
        [TestCase("111,111.11", 0, '.', ',', ExpectedResult = 0)]
        [TestCase("1,111,111.11", 0, '.', ',', ExpectedResult = 0)]
        [TestCase("1,111,111", 0, '.', ',', ExpectedResult = 0)]
        [TestCase("USD 1,111,111.11", 0, '.', ',', ExpectedResult = 0)]
        [TestCase("U$ 1,111,111.11", 0, '.', ',', ExpectedResult = 0)]
        [TestCase("100%", 0, '.', ',', ExpectedResult = 100)]
        [TestCase("99.99%", 0, '.', ',', ExpectedResult = 99)]
        public byte ToByte_FromStringValidNumbers(string stringValue, byte defaultValue, char decimalSeparator, char milharSeparator)
        {
            return stringValue.ToByte(defaultValue, decimalSeparator, milharSeparator);
        }

        [TestCase("", 1, '.', ',', ExpectedResult = 1)]
        [TestCase("R$", 1, '.', ',', ExpectedResult = 1)]
        [TestCase("ABC", 1, '.', ',', ExpectedResult = 1)]
        [TestCase(null, 1, '.', ',', ExpectedResult = 1)]
        public byte ToByte_FromStringInvalidNumbers(string stringValue, byte defaultValue, char decimalSeparator, char milharSeparator)
        {
            return stringValue.ToByte(defaultValue, decimalSeparator, milharSeparator);
        }

        [TestCase("1,11", 0, ',', '.', ExpectedResult = 1)]
        [TestCase("11,11", 0, ',', '.', ExpectedResult = 11)]
        [TestCase("111,11", 0, ',', '.', ExpectedResult = 111)]
        [TestCase("1.111,11", 0, ',', '.', ExpectedResult = 0)]
        [TestCase("11.111,11", 0, ',', '.', ExpectedResult = 0)]
        [TestCase("111.111,11", 0, ',', '.', ExpectedResult = 0)]
        [TestCase("1.111.111,11", 0, ',', '.', ExpectedResult = 0)]
        public byte ToByte_FromStringDifferentSeparators(string stringValue, byte defaultValue, char decimalSeparator, char milharSeparator)
        {
            return stringValue.ToByte(defaultValue, decimalSeparator, milharSeparator);
        }

        [TestCase("0.00", ExpectedResult = 0)]
        [TestCase("0.01", ExpectedResult = 0)]
        [TestCase("0.11", ExpectedResult = 0)]
        [TestCase("1.11", ExpectedResult = 1)]
        [TestCase("11.11", ExpectedResult = 11)]
        [TestCase("111.11", ExpectedResult = 111)]
        [TestCase("1,111.11", ExpectedResult = 0)]
        [TestCase("11,111.11", ExpectedResult = 0)]
        [TestCase("111,111.11", ExpectedResult = 0)]
        [TestCase("1,111,111.11", ExpectedResult = 0)]
        [TestCase("USD 1,111,111.11", ExpectedResult = 0)]
        [TestCase("U$ 1,111,111.11", ExpectedResult = 0)]
        [TestCase("100%", ExpectedResult = 100)]
        [TestCase("99.99%", ExpectedResult = 99)]
        [TestCase("", ExpectedResult = 0)]
        [TestCase("R$", ExpectedResult = 0)]
        [TestCase("ABC", ExpectedResult = 0)]
        [TestCase(null, ExpectedResult = 0)]
        public byte ToByte_FromStringWithoutDefaults(string stringValue)
        {
            return stringValue.ToByte();
        }
    }
}
