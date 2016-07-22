using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.DecimalConverter
{
    [TestFixture]
    public class ToDecimalFromByte
    {
        [TestCase(byte.MinValue, ExpectedResult = byte.MinValue)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(128, ExpectedResult = 128)]
        [TestCase(byte.MaxValue, ExpectedResult = byte.MaxValue)]
        public decimal ToDecimal_FromByte(byte byteValue)
        {
            return byteValue.ToDecimal();
        }

        [TestCase(byte.MinValue, -1, ExpectedResult = byte.MinValue)]
        [TestCase(0, -1, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(128, 0, ExpectedResult = 128)]
        [TestCase(byte.MaxValue, 0, ExpectedResult = byte.MaxValue)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public decimal ToDecimal_FromNullableByte(byte? byteValue, decimal defaultValue = 0)
        {
            return byteValue.ToDecimal(defaultValue);
        }

        
    }
}
