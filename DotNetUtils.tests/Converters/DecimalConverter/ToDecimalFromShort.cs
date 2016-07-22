using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.DecimalConverter
{
    [TestFixture]
    public class ToDecimalFromShort
    {
        [TestCase(short.MinValue, ExpectedResult = short.MinValue)]
        [TestCase(-128, ExpectedResult = -128)]
        [TestCase(-1, ExpectedResult = -1)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(128, ExpectedResult = 128)]
        [TestCase(short.MaxValue, ExpectedResult = short.MaxValue)]
        public decimal ToDecimal_FromShort(short shortValue)
        {
            return shortValue.ToDecimal();
        }

        [TestCase(short.MinValue, -1, ExpectedResult = short.MinValue)]
        [TestCase(-128, 0, ExpectedResult = -128)]
        [TestCase(-1, 0, ExpectedResult = -1)]
        [TestCase(0, -1, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(128, 0, ExpectedResult = 128)]
        [TestCase(short.MaxValue, 0, ExpectedResult = short.MaxValue)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public decimal ToDecimal_FromNullableShort(short? shortValue, decimal defaultValue = 0)
        {
            return shortValue.ToDecimal(defaultValue);
        }

        
    }
}
