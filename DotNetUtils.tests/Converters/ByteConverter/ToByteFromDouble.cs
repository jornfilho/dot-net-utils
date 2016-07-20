using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.ByteConverter
{
    [TestFixture]
    public class ToByteFromDouble
    {
        [TestCase(double.MinValue, 0, ExpectedResult = 0)]
        [TestCase(-1000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(-50.12345d, 0, ExpectedResult = 0)]
        [TestCase(1.99d, 0, ExpectedResult = 1)]
        [TestCase(1.11d, 0, ExpectedResult = 1)]
        [TestCase(50.12345d, 0, ExpectedResult = 50)]
        [TestCase(1000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(double.MaxValue, 0, ExpectedResult = 0)]
        public byte ToByte_FromDouble(double doubleValue, byte defaultValue = 0)
        {
            return doubleValue.ToByte(defaultValue);
        }

        [TestCase(double.MinValue, 0, ExpectedResult = 0)]
        [TestCase(-1000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(-50.12345d, 0, ExpectedResult = 0)]
        [TestCase(1.99d, 0, ExpectedResult = 1)]
        [TestCase(1.11d, 0, ExpectedResult = 1)]
        [TestCase(50.12345d, 0, ExpectedResult = 50)]
        [TestCase(1000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(double.MaxValue, 0, ExpectedResult = 0)]
        [TestCase(null, 0, ExpectedResult = 0)]
        public byte ToByte_FromNullableDouble(double? doubleValue, byte defaultValue = 0)
        {
            return doubleValue.ToByte(defaultValue);
        }
    }
}
