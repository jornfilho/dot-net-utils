using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.DecimalConverter
{
    [TestFixture]
    public class ToDecimalFromInteger
    {
        [TestCase(int.MinValue, ExpectedResult = int.MinValue)]
        [TestCase(-1000000000, ExpectedResult = -1000000000)]
        [TestCase(-1000000, ExpectedResult = -1000000)]
        [TestCase(-1000, ExpectedResult = -1000)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(1000, ExpectedResult = 1000)]
        [TestCase(1000000, ExpectedResult = 1000000)]
        [TestCase(1000000000, ExpectedResult = 1000000000)]
        [TestCase(int.MaxValue, ExpectedResult = int.MaxValue)]
        public long ToLong_FromInteger(int intValue)
        {
            return intValue.ToLong();
        }

        [TestCase(int.MinValue, -1, ExpectedResult = int.MinValue)]
        [TestCase(-1000000000, 0, ExpectedResult = -1000000000)]
        [TestCase(-1000000, 0, ExpectedResult = -1000000)]
        [TestCase(-1000, 0, ExpectedResult = -1000)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(1000, 0, ExpectedResult = 1000)]
        [TestCase(1000000, 0, ExpectedResult = 1000000)]
        [TestCase(1000000000, 0, ExpectedResult = 1000000000)]
        [TestCase(int.MaxValue, -1, ExpectedResult = int.MaxValue)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public long ToLong_FromNullableInteger(int? intValue, long defaultValue = 0)
        {
            return intValue.ToLong(defaultValue);
        }

        
    }
}
