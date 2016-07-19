using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.IntegerConverter
{
    [TestFixture]
    public class ToIntegerFromByte
    {
        [TestCase(byte.MinValue, -1, ExpectedResult = byte.MinValue)]
        [TestCase(0, -1, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(128, 0, ExpectedResult = 128)]
        [TestCase(byte.MaxValue, 0, ExpectedResult = byte.MaxValue)]
        public int ToInteger_FromByte(byte byteValue, int defaultValue = 0)
        {
            return byteValue.ToInteger(defaultValue);
        }

        [TestCase(byte.MinValue, -1, ExpectedResult = byte.MinValue)]
        [TestCase(0, -1, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(128, 0, ExpectedResult = 128)]
        [TestCase(byte.MaxValue, 0, ExpectedResult = byte.MaxValue)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public int ToInteger_FromNullableByte(byte? byteValue, int defaultValue = 0)
        {
            return byteValue.ToInteger(defaultValue);
        }

        
    }
}
