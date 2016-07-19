using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.IntegerConverter
{
    [TestFixture]
    public class FromFloat
    {
        [TestCase(float.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000000000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(-1000000000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(-1000000000.12345f, 0, ExpectedResult = -1000000000)]
        [TestCase(-1000000.12345f, 0, ExpectedResult = -1000000)]
        [TestCase(-1000.12345f, 0, ExpectedResult = -1000)]
        [TestCase(1.99f, 0, ExpectedResult = 1)]
        [TestCase(1.11f, 0, ExpectedResult = 1)]
        [TestCase(1000.12345f, 0, ExpectedResult = 1000)]
        [TestCase(1000000.12345f, 0, ExpectedResult = 1000000)]
        [TestCase(1000000000.12345f, 0, ExpectedResult = 1000000000)]
        [TestCase(1000000000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(1000000000000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(float.MaxValue, -1, ExpectedResult = -1)]
        public int ToIntegerFromFloat(float floatValue, int defaultValue = 0)
        {
            return floatValue.ToInteger(defaultValue);
        }

        [TestCase(float.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000000000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(-1000000000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(-1000000000.12345f, 0, ExpectedResult = -1000000000)]
        [TestCase(-1000000.12345f, 0, ExpectedResult = -1000000)]
        [TestCase(-1000.12345f, 0, ExpectedResult = -1000)]
        [TestCase(1.99f, 0, ExpectedResult = 1)]
        [TestCase(1.11f, 0, ExpectedResult = 1)]
        [TestCase(1000.12345f, 0, ExpectedResult = 1000)]
        [TestCase(1000000.12345f, 0, ExpectedResult = 1000000)]
        [TestCase(1000000000.12345f, 0, ExpectedResult = 1000000000)]
        [TestCase(1000000000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(1000000000000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(float.MaxValue, -1, ExpectedResult = -1)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public int ToIntegerFromNullableFloat(float? floatValue, int defaultValue = 0)
        {
            return floatValue.ToInteger(defaultValue);
        }

        
    }
}
