using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.LongConverter
{
    [TestFixture]
    public class ToLongFromByte
    {
        [TestCase(byte.MinValue, ExpectedResult = byte.MinValue)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(128, ExpectedResult = 128)]
        [TestCase(byte.MaxValue, ExpectedResult = byte.MaxValue)]
        public long ToLong_FromByte(byte byteValue)
        {
            return byteValue.ToLong();
        }

        [TestCase(byte.MinValue, -1, ExpectedResult = byte.MinValue)]
        [TestCase(0, -1, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(128, 0, ExpectedResult = 128)]
        [TestCase(byte.MaxValue, 0, ExpectedResult = byte.MaxValue)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public long ToLong_FromNullableByte(byte? byteValue, long defaultValue = 0)
        {
            return byteValue.ToLong(defaultValue);
        }

        
    }
}
