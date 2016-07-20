using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.ShortConverter
{
    [TestFixture]
    public class ToShortFromLong
    {
        [TestCase(long.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000L, 0, ExpectedResult = 0)]
        [TestCase(-50L, 0, ExpectedResult = -50)]
        [TestCase(1L, 0, ExpectedResult = 1)]
        [TestCase(50L, 0, ExpectedResult = 50)]
        [TestCase(1000000L, 0, ExpectedResult = 0)]
        [TestCase(long.MaxValue, -1, ExpectedResult = -1)]
        public short ToInteger_FromLong(long longValue, short defaultValue = 0)
        {
            return longValue.ToShort(defaultValue);
        }

        [TestCase(long.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000L, 0, ExpectedResult = 0)]
        [TestCase(-50L, 0, ExpectedResult = -50)]
        [TestCase(1L, 0, ExpectedResult = 1)]
        [TestCase(50L, 0, ExpectedResult = 50)]
        [TestCase(1000000L, 0, ExpectedResult = 0)]
        [TestCase(long.MaxValue, -1, ExpectedResult = -1)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public short ToInteger_FromNullableLong(long? longValue, short defaultValue = 0)
        {
            return longValue.ToShort(defaultValue);
        }

        
    }
}
