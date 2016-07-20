using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.ShortConverter
{
    [TestFixture]
    public class ToShortFromByte
    {
        [TestCase(byte.MinValue, ExpectedResult = byte.MinValue)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(128, ExpectedResult = 128)]
        [TestCase(byte.MaxValue, ExpectedResult = byte.MaxValue)]
        public short ToShort_FromByte(byte byteValue)
        {
            return byteValue.ToShort();
        }

        [TestCase(byte.MinValue, -1, ExpectedResult = byte.MinValue)]
        [TestCase(0, -1, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(128, 0, ExpectedResult = 128)]
        [TestCase(byte.MaxValue, 0, ExpectedResult = byte.MaxValue)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public short ToShort_FromNullableByte(byte? byteValue, short defaultValue = 0)
        {
            return byteValue.ToShort(defaultValue);
        }

        
    }
}
