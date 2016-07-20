using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.ByteConverter
{
    [TestFixture]
    public class ToByteFromDecimal
    {
        #region non nullable
        [Test]
        public void ToByte_FromMinDecimal()
        {
            Assert.AreEqual(decimal.MinValue.ToByte(defaultValue: 1), 1);
        }

        [Test]
        public void ToByte_FromSmallNegativeDecimal()
        {
            Assert.AreEqual((-50.1111m).ToByte(defaultValue: 1), 1);
            Assert.AreEqual((-50.9999m).ToByte(defaultValue: 1), 1);
        }

        [Test]
        public void ToByte_FromDecimal()
        {
            Assert.AreEqual((0.1111m).ToByte(defaultValue: 1), 0);
            Assert.AreEqual((0.9999m).ToByte(defaultValue: 1), 0);
        }

        [Test]
        public void ToByte_FromSmallDecimal()
        {
            Assert.AreEqual((50.1111m).ToByte(defaultValue: 1), 50);
            Assert.AreEqual((50.9999m).ToByte(defaultValue: 1), 50);
        }

        [Test]
        public void ToByte_FromMaxDecimal()
        {
            Assert.AreEqual(decimal.MaxValue.ToByte(defaultValue: 1), 1);
        } 
        #endregion

        #region nullable
        [Test]
        public void ToByte_FromNullableMinDecimal()
        {
            Assert.AreEqual(((decimal?)decimal.MinValue).ToByte(1), 1);
        }

        [Test]
        public void ToByte_FromNullableSmallNegativeDecimal()
        {
            Assert.AreEqual(((decimal?)-50.1111m).ToByte(1), 1);
            Assert.AreEqual(((decimal?)-50.9999m).ToByte(1), 1);
        }

        [Test]
        public void ToByte_FromNullableDecimal()
        {
            Assert.AreEqual(((decimal?)0.1111m).ToByte(1), 0);
            Assert.AreEqual(((decimal?)0.9999m).ToByte(1), 0);
        }

        [Test]
        public void ToByte_FromNullableSmallDecimal()
        {
            Assert.AreEqual(((decimal?)50.1111m).ToByte(1), 50);
            Assert.AreEqual(((decimal?)50.9999m).ToByte(1), 50);
        }

        [Test]
        public void ToByte_FromNullableMaxDecimal()
        {
            Assert.AreEqual(((decimal?)decimal.MaxValue).ToByte(1), 1);
        }

        [Test]
        public void ToByte_FromNullableNullDecimal()
        {
            Assert.AreEqual(((decimal?)null).ToByte(1), 1);
        }
        #endregion
        
    }
}
