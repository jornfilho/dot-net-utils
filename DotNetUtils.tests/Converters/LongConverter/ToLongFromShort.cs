using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.LongConverter
{
    [TestFixture]
    public class ToLongFromShort
    {
        [TestCase(short.MinValue, ExpectedResult = short.MinValue)]
        [TestCase(-128, ExpectedResult = -128)]
        [TestCase(-1, ExpectedResult = -1)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(128, ExpectedResult = 128)]
        [TestCase(short.MaxValue, ExpectedResult = short.MaxValue)]
        public long ToLong_FromShort(short shortValue)
        {
            return shortValue.ToLong();
        }

        [TestCase(short.MinValue, -1, ExpectedResult = short.MinValue)]
        [TestCase(-128, 0, ExpectedResult = -128)]
        [TestCase(-1, 0, ExpectedResult = -1)]
        [TestCase(0, -1, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(128, 0, ExpectedResult = 128)]
        [TestCase(short.MaxValue, 0, ExpectedResult = short.MaxValue)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public long ToLong_FromNullableShort(short? shortValue, long defaultValue = 0)
        {
            return shortValue.ToLong(defaultValue);
        }

        
    }
}
