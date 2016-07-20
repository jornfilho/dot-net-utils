using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.ByteConverter
{
    [TestFixture]
    public class ToByteFromShort
    {
        [TestCase(short.MinValue, 1, ExpectedResult = 1)]
        [TestCase((short)-128, ExpectedResult = 0)]
        [TestCase((short)-1, ExpectedResult = 0)]
        [TestCase((short)0, ExpectedResult = 0)]
        [TestCase((short)1, ExpectedResult = 1)]
        [TestCase((short)128, ExpectedResult = 128)]
        [TestCase(short.MaxValue, ExpectedResult = 0)]
        public byte ToByte_FromShort(short shortValue, byte defaultValue = 0)
        {
            return shortValue.ToByte(defaultValue);
        }

        [TestCase(short.MinValue, 1, ExpectedResult = 1)]
        [TestCase(-128, 0, ExpectedResult = 0)]
        [TestCase(-1, 0, ExpectedResult = 0)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(128, 0, ExpectedResult = 128)]
        [TestCase(short.MaxValue, 0, ExpectedResult = 0)]
        [TestCase(null, 1, ExpectedResult = 1)]
        public byte ToByte_FromNullableShort(short? shortValue, byte defaultValue = 0)
        {
            return shortValue.ToByte(defaultValue);
        }

        
    }
}
