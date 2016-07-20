using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.LongConverter
{
    [TestFixture]
    public class ToLongFromFloat
    {
        [TestCase(float.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000000000000.12345f, 0, ExpectedResult = -1000000000000000)]
        [TestCase(-1000000000000.12345f, 0, ExpectedResult = -1000000000000)]
        [TestCase(-1000000000.12345f, 0, ExpectedResult = -1000000000)]
        [TestCase(-1000000.12345f, 0, ExpectedResult = -1000000)]
        [TestCase(-1000.12345f, 0, ExpectedResult = -1000)]
        [TestCase(1.99f, 0, ExpectedResult = 1)]
        [TestCase(1.11f, 0, ExpectedResult = 1)]
        [TestCase(1000.12345f, 0, ExpectedResult = 1000)]
        [TestCase(1000000.12345f, 0, ExpectedResult = 1000000)]
        [TestCase(1000000000.12345f, 0, ExpectedResult = 1000000000)]
        [TestCase(1000000000000.12345f, 0, ExpectedResult = 1000000000000)]
        [TestCase(1000000000000000.12345f, 0, ExpectedResult = 1000000000000000)]
        [TestCase(float.MaxValue, -1, ExpectedResult = -1)]
        public long ToLong_FromFloat(float floatValue, long defaultValue = 0)
        {
            return floatValue.ToLong(defaultValue);
        }

        [TestCase(float.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000000000000.12345f, 0, ExpectedResult = -1000000000000000)]
        [TestCase(-1000000000000.12345f, 0, ExpectedResult = -1000000000000)]
        [TestCase(-1000000000.12345f, 0, ExpectedResult = -1000000000)]
        [TestCase(-1000000.12345f, 0, ExpectedResult = -1000000)]
        [TestCase(-1000.12345f, 0, ExpectedResult = -1000)]
        [TestCase(1.99f, 0, ExpectedResult = 1)]
        [TestCase(1.11f, 0, ExpectedResult = 1)]
        [TestCase(1000.12345f, 0, ExpectedResult = 1000)]
        [TestCase(1000000.12345f, 0, ExpectedResult = 1000000)]
        [TestCase(1000000000.12345f, 0, ExpectedResult = 1000000000)]
        [TestCase(1000000000000.12345f, 0, ExpectedResult = 1000000000000)]
        [TestCase(1000000000000000.12345f, 0, ExpectedResult = 1000000000000000)]
        [TestCase(float.MaxValue, -1, ExpectedResult = -1)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public long ToLong_FromNullableFloat(float? floatValue, long defaultValue = 0)
        {
            return floatValue.ToLong(defaultValue);
        }

        
    }
}
