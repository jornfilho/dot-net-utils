using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.ByteConverter
{
    [TestFixture]
    public class ToByteFromInteger
    {
        [TestCase(int.MinValue, ExpectedResult = 0)]
        [TestCase(-1000000, ExpectedResult = 0)]
        [TestCase(-50, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(50, ExpectedResult = 50)]
        [TestCase(1000000, ExpectedResult = 0)]
        [TestCase(int.MaxValue, ExpectedResult = 0)]
        public byte ToByte_FromInteger(int intValue, byte defaultValue = 0)
        {
            return intValue.ToByte(defaultValue);
        }

        [TestCase(int.MinValue, ExpectedResult = 0)]
        [TestCase(-1000000, ExpectedResult = 0)]
        [TestCase(-50, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(50, ExpectedResult = 50)]
        [TestCase(1000000, ExpectedResult = 0)]
        [TestCase(null, 0, ExpectedResult = 0)]
        public byte ToByte_FromNullableInteger(int? intValue, byte defaultValue = 0)
        {
            return intValue.ToByte(defaultValue);
        }

        
    }
}
