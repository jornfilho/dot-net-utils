using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.ShortConverter
{
    [TestFixture]
    public class ToShortFromDouble
    {
        [TestCase(double.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(-50.12345d, 0, ExpectedResult = -50)]
        [TestCase(1.99d, 0, ExpectedResult = 1)]
        [TestCase(1.11d, 0, ExpectedResult = 1)]
        [TestCase(50.12345d, 0, ExpectedResult = 50)]
        [TestCase(1000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(double.MaxValue, -1, ExpectedResult = -1)]
        public short ToShort_FromDouble(double doubleValue, short defaultValue = 0)
        {
            return doubleValue.ToShort(defaultValue);
        }

        [TestCase(double.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(-50.12345d, 0, ExpectedResult = -50)]
        [TestCase(1.99d, 0, ExpectedResult = 1)]
        [TestCase(1.11d, 0, ExpectedResult = 1)]
        [TestCase(50.12345d, 0, ExpectedResult = 50)]
        [TestCase(1000000.12345d, 0, ExpectedResult = 0)]
        [TestCase(double.MaxValue, -1, ExpectedResult = -1)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public short ToShort_FromNullableDouble(double? doubleValue, short defaultValue = 0)
        {
            return doubleValue.ToShort(defaultValue);
        }
    }
}
