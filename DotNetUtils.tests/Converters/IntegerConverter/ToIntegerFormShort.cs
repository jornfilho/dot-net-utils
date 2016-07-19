using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.IntegerConverter
{
    [TestFixture]
    public class ToIntegerFromShort
    {
        [TestCase(short.MinValue, -1, ExpectedResult = short.MinValue)]
        [TestCase(-128, 0, ExpectedResult = -128)]
        [TestCase(-1, 0, ExpectedResult = -1)]
        [TestCase(0, -1, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(128, 0, ExpectedResult = 128)]
        [TestCase(short.MaxValue, 0, ExpectedResult = short.MaxValue)]
        public int ToInteger_FromShort(short shortValue, int defaultValue = 0)
        {
            return shortValue.ToInteger(defaultValue);
        }

        [TestCase(short.MinValue, -1, ExpectedResult = short.MinValue)]
        [TestCase(-128, 0, ExpectedResult = -128)]
        [TestCase(-1, 0, ExpectedResult = -1)]
        [TestCase(0, -1, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(128, 0, ExpectedResult = 128)]
        [TestCase(short.MaxValue, 0, ExpectedResult = short.MaxValue)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public int ToInteger_FromNullableShort(short? shortValue, int defaultValue = 0)
        {
            return shortValue.ToInteger(defaultValue);
        }

        
    }
}
