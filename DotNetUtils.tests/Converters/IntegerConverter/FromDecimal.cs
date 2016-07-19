using DotNetUtils.Converters;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace DotNetUtils.tests.Converters.IntegerConverter
{
    [TestFixture]
    public class FromDecimal
    {
        #region non nullable
        [Test]
        public void ToIntegerFromMinDecimal()
        {
            Assert.AreEqual(decimal.MinValue.ToInteger(-1), -1);
        }

        [Test]
        public void ToIntegerFromVerySmallNegativeDecimal()
        {
            Assert.AreEqual((-1000000000000000.1111m).ToInteger(-1), -1);
        }

        [Test]
        public void ToIntegerFromSmallNegativeDecimal()
        {
            Assert.AreEqual((-10000000.1111m).ToInteger(-1), -10000000);
            Assert.AreEqual((-10000000.9999m).ToInteger(-1), -10000000);
        }

        [Test]
        public void ToIntegerFromDecimal()
        {
            Assert.AreEqual((0.1111m).ToInteger(-1), 0);
            Assert.AreEqual((0.9999m).ToInteger(-1), 0);
        }

        [Test]
        public void ToIntegerFromSmallDecimal()
        {
            Assert.AreEqual((10000000.1111m).ToInteger(-1), 10000000);
            Assert.AreEqual((10000000.9999m).ToInteger(-1), 10000000);
        }

        [Test]
        public void ToIntegerFromVerySmallDecimal()
        {
            Assert.AreEqual((1000000000000000.1111m).ToInteger(-1), -1);
        }

        [Test]
        public void ToIntegerFromMaxDecimal()
        {
            Assert.AreEqual(decimal.MaxValue.ToInteger(-1), -1);
        } 
        #endregion

        #region nullable
        [Test]
        public void ToIntegerFromNullableMinDecimal()
        {
            Assert.AreEqual(((decimal?)decimal.MinValue).ToInteger(-1), -1);
        }

        [Test]
        public void ToIntegerFromNullableVerySmallNegativeDecimal()
        {
            Assert.AreEqual(((decimal?)-1000000000000000.1111m).ToInteger(-1), -1);
        }

        [Test]
        public void ToIntegerFromNullableSmallNegativeDecimal()
        {
            Assert.AreEqual(((decimal?)-10000000.1111m).ToInteger(-1), -10000000);
            Assert.AreEqual(((decimal?)-10000000.9999m).ToInteger(-1), -10000000);
        }

        [Test]
        public void ToIntegerFromNullableDecimal()
        {
            Assert.AreEqual(((decimal?)0.1111m).ToInteger(-1), 0);
            Assert.AreEqual(((decimal?)0.9999m).ToInteger(-1), 0);
        }

        [Test]
        public void ToIntegerFromNullableSmallDecimal()
        {
            Assert.AreEqual(((decimal?)10000000.1111m).ToInteger(-1), 10000000);
            Assert.AreEqual(((decimal?)10000000.9999m).ToInteger(-1), 10000000);
        }

        [Test]
        public void ToIntegerFromNullableVerySmallDecimal()
        {
            Assert.AreEqual(((decimal?)1000000000000000.1111m).ToInteger(-1), -1);
        }

        [Test]
        public void ToIntegerFromNullableMaxDecimal()
        {
            Assert.AreEqual(((decimal?)decimal.MaxValue).ToInteger(-1), -1);
        }

        [Test]
        public void ToIntegerFromNullableNullDecimal()
        {
            Assert.AreEqual(((decimal?)null).ToInteger(-1), -1);
        }
        #endregion
        
    }
}
