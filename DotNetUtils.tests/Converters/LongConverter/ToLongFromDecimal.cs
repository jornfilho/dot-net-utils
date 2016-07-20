using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.LongConverter
{
    [TestFixture]
    public class ToLongFromDecimal
    {
        #region non nullable
        [Test]
        public void ToLong_FromMinDecimal()
        {
            Assert.AreEqual(decimal.MinValue.ToLong(-1), -1);
        }

        [Test]
        public void ToLong_FromVerySmallNegativeDecimal()
        {
            Assert.AreEqual((-1000000000000000.1111m).ToLong(-1), -1000000000000000);
        }

        [Test]
        public void ToLong_FromSmallNegativeDecimal()
        {
            Assert.AreEqual((-10000000.1111m).ToLong(-1), -10000000);
            Assert.AreEqual((-10000000.9999m).ToLong(-1), -10000000);
        }

        [Test]
        public void ToLong_FromDecimal()
        {
            Assert.AreEqual((0.1111m).ToLong(-1), 0);
            Assert.AreEqual((0.9999m).ToLong(-1), 0);
        }

        [Test]
        public void ToLong_FromSmallDecimal()
        {
            Assert.AreEqual((10000000.1111m).ToLong(-1), 10000000);
            Assert.AreEqual((10000000.9999m).ToLong(-1), 10000000);
        }

        [Test]
        public void ToLong_FromVerySmallDecimal()
        {
            Assert.AreEqual((1000000000000000.1111m).ToLong(-1), 1000000000000000);
        }

        [Test]
        public void ToLong_FromMaxDecimal()
        {
            Assert.AreEqual(decimal.MaxValue.ToLong(-1), -1);
        } 
        #endregion

        #region nullable
        [Test]
        public void ToLong_FromNullableMinDecimal()
        {
            Assert.AreEqual(((decimal?)decimal.MinValue).ToLong(-1), -1);
        }

        [Test]
        public void ToLong_FromNullableVerySmallNegativeDecimal()
        {
            Assert.AreEqual(((decimal?)-1000000000000000.1111m).ToLong(-1), -1000000000000000);
        }

        [Test]
        public void ToLong_FromNullableSmallNegativeDecimal()
        {
            Assert.AreEqual(((decimal?)-10000000.1111m).ToLong(-1), -10000000);
            Assert.AreEqual(((decimal?)-10000000.9999m).ToLong(-1), -10000000);
        }

        [Test]
        public void ToLong_FromNullableDecimal()
        {
            Assert.AreEqual(((decimal?)0.1111m).ToLong(-1), 0);
            Assert.AreEqual(((decimal?)0.9999m).ToLong(-1), 0);
        }

        [Test]
        public void ToLong_FromNullableSmallDecimal()
        {
            Assert.AreEqual(((decimal?)10000000.1111m).ToLong(-1), 10000000);
            Assert.AreEqual(((decimal?)10000000.9999m).ToLong(-1), 10000000);
        }

        [Test]
        public void ToLong_FromNullableVerySmallDecimal()
        {
            Assert.AreEqual(((decimal?)1000000000000000.1111m).ToLong(-1), 1000000000000000);
        }

        [Test]
        public void ToLong_FromNullableMaxDecimal()
        {
            Assert.AreEqual(((decimal?)decimal.MaxValue).ToLong(-1), -1);
        }

        [Test]
        public void ToLong_FromNullableNullDecimal()
        {
            Assert.AreEqual(((decimal?)null).ToLong(-1), -1);
        }
        #endregion
        
    }
}
