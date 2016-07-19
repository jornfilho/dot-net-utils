using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.IntegerConverter
{
    [TestFixture]
    public class ToIntegerFromDouble
    {
        [TestCase(double.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000000000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(-1000000000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(-1000000000.12345d, 0, ExpectedResult = -1000000000)]
        [TestCase(-1000000.12345d, 0, ExpectedResult = -1000000)]
        [TestCase(-1000.12345d, 0, ExpectedResult = -1000)]
        [TestCase(1.99d, 0, ExpectedResult = 1)]
        [TestCase(1.11d, 0, ExpectedResult = 1)]
        [TestCase(1000.12345d, 0, ExpectedResult = 1000)]
        [TestCase(1000000.12345d, 0, ExpectedResult = 1000000)]
        [TestCase(1000000000.12345d, 0, ExpectedResult = 1000000000)]
        [TestCase(1000000000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(1000000000000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(double.MaxValue, -1, ExpectedResult = -1)]
        public int ToInteger_FromDouble(double doubleValue, int defaultValue = 0)
        {
            return doubleValue.ToInteger(defaultValue);
        }

        [TestCase(double.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000000000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(-1000000000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(-1000000000.12345d, 0, ExpectedResult = -1000000000)]
        [TestCase(-1000000.12345d, 0, ExpectedResult = -1000000)]
        [TestCase(-1000.12345d, 0, ExpectedResult = -1000)]
        [TestCase(1.99d, 0, ExpectedResult = 1)]
        [TestCase(1.11d, 0, ExpectedResult = 1)]
        [TestCase(1000.12345d, 0, ExpectedResult = 1000)]
        [TestCase(1000000.12345d, 0, ExpectedResult = 1000000)]
        [TestCase(1000000000.12345d, 0, ExpectedResult = 1000000000)]
        [TestCase(1000000000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(1000000000000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(double.MaxValue, -1, ExpectedResult = -1)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public int ToInteger_FromNullableDouble(double? doubleValue, int defaultValue = 0)
        {
            return doubleValue.ToInteger(defaultValue);
        }

        
    }
}
