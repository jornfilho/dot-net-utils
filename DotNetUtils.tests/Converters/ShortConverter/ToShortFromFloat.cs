using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.ShortConverter
{
    [TestFixture]
    public class ToShortFromFloat
    {
        [TestCase(float.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(-50.12345f, 0, ExpectedResult = -50)]
        [TestCase(1.99f, 0, ExpectedResult = 1)]
        [TestCase(1.11f, 0, ExpectedResult = 1)]
        [TestCase(50.12345f, 0, ExpectedResult = 50)]
        [TestCase(1000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(float.MaxValue, -1, ExpectedResult = -1)]
        public short ToShort_FromFloat(float floatValue, short defaultValue = 0)
        {
            return floatValue.ToShort(defaultValue);
        }

        [TestCase(float.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(-50.12345f, 0, ExpectedResult = -50)]
        [TestCase(1.99f, 0, ExpectedResult = 1)]
        [TestCase(1.11f, 0, ExpectedResult = 1)]
        [TestCase(50.12345f, 0, ExpectedResult = 50)]
        [TestCase(1000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(float.MaxValue, -1, ExpectedResult = -1)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public short ToShort_FromNullableFloat(float? floatValue, short defaultValue = 0)
        {
            return floatValue.ToShort(defaultValue);
        }

        
    }
}
