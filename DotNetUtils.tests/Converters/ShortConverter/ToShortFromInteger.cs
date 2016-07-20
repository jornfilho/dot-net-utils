using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.ShortConverter
{
    [TestFixture]
    public class ToShortFromInteger
    {
        [TestCase(int.MinValue, ExpectedResult = 0)]
        [TestCase(-1000000, ExpectedResult = 0)]
        [TestCase(-50, ExpectedResult = -50)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(50, ExpectedResult = 50)]
        [TestCase(1000000, ExpectedResult = 0)]
        [TestCase(int.MaxValue, ExpectedResult = 0)]
        public short ToShort_FromInteger(int intValue, short defaultValue = 0)
        {
            return intValue.ToShort(defaultValue);
        }

        [TestCase(int.MinValue, ExpectedResult = 0)]
        [TestCase(-1000000, ExpectedResult = 0)]
        [TestCase(-50, ExpectedResult = -50)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(50, ExpectedResult = 50)]
        [TestCase(1000000, ExpectedResult = 0)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public short ToShort_FromNullableInteger(int? intValue, short defaultValue = 0)
        {
            return intValue.ToShort(defaultValue);
        }

        
    }
}
