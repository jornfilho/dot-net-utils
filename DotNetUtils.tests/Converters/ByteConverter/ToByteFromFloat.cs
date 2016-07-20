using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.ByteConverter
{
    [TestFixture]
    public class ToByteFromFloat
    {
        [TestCase(float.MinValue, 0, ExpectedResult = 0)]
        [TestCase(-1000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(-50.12345f, 0, ExpectedResult = 0)]
        [TestCase(1.99f, 0, ExpectedResult = 1)]
        [TestCase(1.11f, 0, ExpectedResult = 1)]
        [TestCase(50.12345f, 0, ExpectedResult = 50)]
        [TestCase(1000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(float.MaxValue, 0, ExpectedResult = 0)]
        public byte ToByte_FromFloat(float floatValue, byte defaultValue = 0)
        {
            return floatValue.ToByte(defaultValue);
        }

        [TestCase(float.MinValue, 0, ExpectedResult = 0)]
        [TestCase(-1000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(-50.12345f, 0, ExpectedResult = 0)]
        [TestCase(1.99f, 0, ExpectedResult = 1)]
        [TestCase(1.11f, 0, ExpectedResult = 1)]
        [TestCase(50.12345f, 0, ExpectedResult = 50)]
        [TestCase(1000000.12345f, 0, ExpectedResult = 0)]
        [TestCase(float.MaxValue, 0, ExpectedResult = 0)]
        [TestCase(null, 0, ExpectedResult = 0)]
        public byte ToByte_FromNullableFloat(float? floatValue, byte defaultValue = 0)
        {
            return floatValue.ToByte(defaultValue);
        }

        
    }
}
