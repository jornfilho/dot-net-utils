using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.DecimalConverter
{
    [TestFixture]
    public class ToDecimalFromLong
    {
        [TestCase(long.MinValue, ExpectedResult = long.MinValue)]
        [TestCase(-1000000000000000L, ExpectedResult = -1000000000000000)]
        [TestCase(-1000000000000L, ExpectedResult = -1000000000000)]
        [TestCase(-1000000000L, ExpectedResult = -1000000000)]
        [TestCase(-1000000L, ExpectedResult = -1000000)]
        [TestCase(-1000L, ExpectedResult = -1000)]
        [TestCase(1L, ExpectedResult = 1)]
        [TestCase(1000L, ExpectedResult = 1000)]
        [TestCase(1000000L, ExpectedResult = 1000000)]
        [TestCase(1000000000L, ExpectedResult = 1000000000)]
        [TestCase(1000000000000L, ExpectedResult = 1000000000000)]
        [TestCase(1000000000000000L, ExpectedResult = 1000000000000000)]
        [TestCase(long.MaxValue, ExpectedResult = long.MaxValue)]
        public decimal ToDecimal_FromLong(long longValue)
        {
            return longValue.ToDecimal();
        }

        [TestCase(long.MinValue, -1, ExpectedResult = long.MinValue)]
        [TestCase(-1000000000000000L, 0, ExpectedResult = -1000000000000000)]
        [TestCase(-1000000000000L, 0, ExpectedResult = -1000000000000)]
        [TestCase(-1000000000L, 0, ExpectedResult = -1000000000)]
        [TestCase(-1000000L, 0, ExpectedResult = -1000000)]
        [TestCase(-1000L, 0, ExpectedResult = -1000)]
        [TestCase(1L, 0, ExpectedResult = 1)]
        [TestCase(1000L, 0, ExpectedResult = 1000)]
        [TestCase(1000000L, 0, ExpectedResult = 1000000)]
        [TestCase(1000000000L, 0, ExpectedResult = 1000000000)]
        [TestCase(1000000000000L, 0, ExpectedResult = 1000000000000)]
        [TestCase(1000000000000000L, 0, ExpectedResult = 1000000000000000)]
        [TestCase(long.MaxValue, -1, ExpectedResult = long.MaxValue)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public decimal ToDecimal_FromNullableLong(long? longValue, decimal defaultValue = 0)
        {
            return longValue.ToDecimal(defaultValue);
        }

        
    }
}
