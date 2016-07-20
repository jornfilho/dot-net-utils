using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.LongConverter
{
    [TestFixture]
    public class ToLongFromDouble
    {
        [TestCase(double.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000000000000.12345d, 0, ExpectedResult = -1000000000000000)]
        [TestCase(-1000000000000.12345d, 0, ExpectedResult = -1000000000000)]
        [TestCase(-1000000000.12345d, 0, ExpectedResult = -1000000000)]
        [TestCase(-1000000.12345d, 0, ExpectedResult = -1000000)]
        [TestCase(-1000.12345d, 0, ExpectedResult = -1000)]
        [TestCase(1.99d, 0, ExpectedResult = 1)]
        [TestCase(1.11d, 0, ExpectedResult = 1)]
        [TestCase(1000.12345d, 0, ExpectedResult = 1000)]
        [TestCase(1000000.12345d, 0, ExpectedResult = 1000000)]
        [TestCase(1000000000.12345d, 0, ExpectedResult = 1000000000)]
        [TestCase(1000000000000.12345d, 0, ExpectedResult = 1000000000000)]
        [TestCase(1000000000000000.12345d, 0, ExpectedResult = 1000000000000000)]
        [TestCase(double.MaxValue, -1, ExpectedResult = -1)]
        public long ToLong_FromDouble(double doubleValue, long defaultValue = 0)
        {
            return doubleValue.ToLong(defaultValue);
        }

        [TestCase(double.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000000000000.12345d, 0, ExpectedResult = -1000000000000000)]
        [TestCase(-1000000000000.12345d, 0, ExpectedResult = -1000000000000)]
        [TestCase(-1000000000.12345d, 0, ExpectedResult = -1000000000)]
        [TestCase(-1000000.12345d, 0, ExpectedResult = -1000000)]
        [TestCase(-1000.12345d, 0, ExpectedResult = -1000)]
        [TestCase(1.99d, 0, ExpectedResult = 1)]
        [TestCase(1.11d, 0, ExpectedResult = 1)]
        [TestCase(1000.12345d, 0, ExpectedResult = 1000)]
        [TestCase(1000000.12345d, 0, ExpectedResult = 1000000)]
        [TestCase(1000000000.12345d, 0, ExpectedResult = 1000000000)]
        [TestCase(1000000000000.12345d, 0, ExpectedResult = 1000000000000)]
        [TestCase(1000000000000000.12345d, 0, ExpectedResult = 1000000000000000)]
        [TestCase(double.MaxValue, -1, ExpectedResult = -1)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public long ToLong_FromNullableDouble(double? doubleValue, long defaultValue = 0)
        {
            return doubleValue.ToLong(defaultValue);
        }
    }
}
