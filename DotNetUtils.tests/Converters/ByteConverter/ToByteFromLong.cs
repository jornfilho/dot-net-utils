using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.ByteConverter
{
    [TestFixture]
    public class ToByteFromLong
    {
        [TestCase(long.MinValue, 1, ExpectedResult = 1)]
        [TestCase(-1000000L, 0, ExpectedResult = 0)]
        [TestCase(-50L, 0, ExpectedResult = 0)]
        [TestCase(1L, 0, ExpectedResult = 1)]
        [TestCase(50L, 0, ExpectedResult = 50)]
        [TestCase(1000000L, 0, ExpectedResult = 0)]
        [TestCase(long.MaxValue, 0, ExpectedResult = 0)]
        public byte ToInteger_FromLong(long longValue, byte defaultValue = 0)
        {
            return longValue.ToByte(defaultValue);
        }

        [TestCase(long.MinValue, 1, ExpectedResult = 1)]
        [TestCase(-1000000L, 0, ExpectedResult = 0)]
        [TestCase(-50L, 0, ExpectedResult = 0)]
        [TestCase(1L, 0, ExpectedResult = 1)]
        [TestCase(50L, 0, ExpectedResult = 50)]
        [TestCase(1000000L, 0, ExpectedResult = 0)]
        [TestCase(long.MaxValue, 0, ExpectedResult = 0)]
        [TestCase(null, 0, ExpectedResult = 0)]
        public byte ToInteger_FromNullableLong(long? longValue, byte defaultValue = 0)
        {
            return longValue.ToByte(defaultValue);
        }

        
    }
}
