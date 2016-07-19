using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.IntegerConverter
{
    [TestFixture]
    public class ToIntegerFromLong
    {
        [TestCase(long.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000000000000L, 0, ExpectedResult = 0)]
        [TestCase(-1000000000000L, 0, ExpectedResult = 0)]
        [TestCase(-1000000000L, 0, ExpectedResult = -1000000000)]
        [TestCase(-1000000L, 0, ExpectedResult = -1000000)]
        [TestCase(-1000L, 0, ExpectedResult = -1000)]
        [TestCase(1L, 0, ExpectedResult = 1)]
        [TestCase(1000L, 0, ExpectedResult = 1000)]
        [TestCase(1000000L, 0, ExpectedResult = 1000000)]
        [TestCase(1000000000L, 0, ExpectedResult = 1000000000)]
        [TestCase(1000000000000L, 0, ExpectedResult = 0)]
        [TestCase(1000000000000000L, 0, ExpectedResult = 0)]
        [TestCase(long.MaxValue, -1, ExpectedResult = -1)]
        public int ToInteger_FromLong(long longValue, int defaultValue = 0)
        {
            return longValue.ToInteger(defaultValue);
        }

        [TestCase(long.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000000000000L, 0, ExpectedResult = 0)]
        [TestCase(-1000000000000L, 0, ExpectedResult = 0)]
        [TestCase(-1000000000L, 0, ExpectedResult = -1000000000)]
        [TestCase(-1000000L, 0, ExpectedResult = -1000000)]
        [TestCase(-1000L, 0, ExpectedResult = -1000)]
        [TestCase(1L, 0, ExpectedResult = 1)]
        [TestCase(1000L, 0, ExpectedResult = 1000)]
        [TestCase(1000000L, 0, ExpectedResult = 1000000)]
        [TestCase(1000000000L, 0, ExpectedResult = 1000000000)]
        [TestCase(1000000000000L, 0, ExpectedResult = 0)]
        [TestCase(1000000000000000L, 0, ExpectedResult = 0)]
        [TestCase(long.MaxValue, -1, ExpectedResult = -1)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public int ToInteger_FromNullableLong(long? longValue, int defaultValue = 0)
        {
            return longValue.ToInteger(defaultValue);
        }

        
    }
}
