using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.IntegerConverter
{
    [TestFixture]
    public class ToIntegerFromDecimal
    {
        #region non nullable
        [Test]
        public void ToInteger_FromMinDecimal()
        {
            Assert.AreEqual(decimal.MinValue.ToInteger(-1), -1);
        }

        [Test]
        public void ToInteger_FromVerySmallNegativeDecimal()
        {
            Assert.AreEqual((-1000000000000000.1111m).ToInteger(-1), -1);
        }

        [Test]
        public void ToInteger_FromSmallNegativeDecimal()
        {
            Assert.AreEqual((-10000000.1111m).ToInteger(-1), -10000000);
            Assert.AreEqual((-10000000.9999m).ToInteger(-1), -10000000);
        }

        [Test]
        public void ToInteger_FromDecimal()
        {
            Assert.AreEqual((0.1111m).ToInteger(-1), 0);
            Assert.AreEqual((0.9999m).ToInteger(-1), 0);
        }

        [Test]
        public void ToInteger_FromSmallDecimal()
        {
            Assert.AreEqual((10000000.1111m).ToInteger(-1), 10000000);
            Assert.AreEqual((10000000.9999m).ToInteger(-1), 10000000);
        }

        [Test]
        public void ToInteger_FromVerySmallDecimal()
        {
            Assert.AreEqual((1000000000000000.1111m).ToInteger(-1), -1);
        }

        [Test]
        public void ToInteger_FromMaxDecimal()
        {
            Assert.AreEqual(decimal.MaxValue.ToInteger(-1), -1);
        } 
        #endregion

        #region nullable
        [Test]
        public void ToInteger_FromNullableMinDecimal()
        {
            Assert.AreEqual(((decimal?)decimal.MinValue).ToInteger(-1), -1);
        }

        [Test]
        public void ToInteger_FromNullableVerySmallNegativeDecimal()
        {
            Assert.AreEqual(((decimal?)-1000000000000000.1111m).ToInteger(-1), -1);
        }

        [Test]
        public void ToInteger_FromNullableSmallNegativeDecimal()
        {
            Assert.AreEqual(((decimal?)-10000000.1111m).ToInteger(-1), -10000000);
            Assert.AreEqual(((decimal?)-10000000.9999m).ToInteger(-1), -10000000);
        }

        [Test]
        public void ToInteger_FromNullableDecimal()
        {
            Assert.AreEqual(((decimal?)0.1111m).ToInteger(-1), 0);
            Assert.AreEqual(((decimal?)0.9999m).ToInteger(-1), 0);
        }

        [Test]
        public void ToInteger_FromNullableSmallDecimal()
        {
            Assert.AreEqual(((decimal?)10000000.1111m).ToInteger(-1), 10000000);
            Assert.AreEqual(((decimal?)10000000.9999m).ToInteger(-1), 10000000);
        }

        [Test]
        public void ToInteger_FromNullableVerySmallDecimal()
        {
            Assert.AreEqual(((decimal?)1000000000000000.1111m).ToInteger(-1), -1);
        }

        [Test]
        public void ToInteger_FromNullableMaxDecimal()
        {
            Assert.AreEqual(((decimal?)decimal.MaxValue).ToInteger(-1), -1);
        }

        [Test]
        public void ToInteger_FromNullableNullDecimal()
        {
            Assert.AreEqual(((decimal?)null).ToInteger(-1), -1);
        }
        #endregion
        
    }
}
