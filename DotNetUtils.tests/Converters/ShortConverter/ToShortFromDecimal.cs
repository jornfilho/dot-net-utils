using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.ShortConverter
{
    [TestFixture]
    public class ToShortFromDecimal
    {
        #region non nullable
        [Test]
        public void ToShort_FromMinDecimal()
        {
            Assert.AreEqual(decimal.MinValue.ToShort(-1), -1);
        }

        [Test]
        public void ToShort_FromVerySmallNegativeDecimal()
        {
            Assert.AreEqual((-1000000000000000.1111m).ToShort(-1), -1);
        }

        [Test]
        public void ToShort_FromSmallNegativeDecimal()
        {
            Assert.AreEqual((-50.1111m).ToShort(-1), -50);
            Assert.AreEqual((-50.9999m).ToShort(-1), -50);
        }

        [Test]
        public void ToShort_FromDecimal()
        {
            Assert.AreEqual((0.1111m).ToShort(-1), 0);
            Assert.AreEqual((0.9999m).ToShort(-1), 0);
        }

        [Test]
        public void ToShort_FromSmallDecimal()
        {
            Assert.AreEqual((50.1111m).ToShort(-1), 50);
            Assert.AreEqual((50.9999m).ToShort(-1), 50);
        }

        [Test]
        public void ToShort_FromVerySmallDecimal()
        {
            Assert.AreEqual((1000000000000000.1111m).ToShort(-1), -1);
        }

        [Test]
        public void ToShort_FromMaxDecimal()
        {
            Assert.AreEqual(decimal.MaxValue.ToShort(-1), -1);
        } 
        #endregion

        #region nullable
        [Test]
        public void ToShort_FromNullableMinDecimal()
        {
            Assert.AreEqual(((decimal?)decimal.MinValue).ToShort(-1), -1);
        }

        [Test]
        public void ToShort_FromNullableVerySmallNegativeDecimal()
        {
            Assert.AreEqual(((decimal?)-1000000000000000.1111m).ToShort(-1), -1);
        }

        [Test]
        public void ToShort_FromNullableSmallNegativeDecimal()
        {
            Assert.AreEqual(((decimal?)-50.1111m).ToShort(-1), -50);
            Assert.AreEqual(((decimal?)-50.9999m).ToShort(-1), -50);
        }

        [Test]
        public void ToShort_FromNullableDecimal()
        {
            Assert.AreEqual(((decimal?)0.1111m).ToShort(-1), 0);
            Assert.AreEqual(((decimal?)0.9999m).ToShort(-1), 0);
        }

        [Test]
        public void ToShort_FromNullableSmallDecimal()
        {
            Assert.AreEqual(((decimal?)50.1111m).ToShort(-1), 50);
            Assert.AreEqual(((decimal?)50.9999m).ToShort(-1), 50);
        }

        [Test]
        public void ToShort_FromNullableVerySmallDecimal()
        {
            Assert.AreEqual(((decimal?)1000000000000000.1111m).ToShort(-1), -1);
        }

        [Test]
        public void ToShort_FromNullableMaxDecimal()
        {
            Assert.AreEqual(((decimal?)decimal.MaxValue).ToShort(-1), -1);
        }

        [Test]
        public void ToShort_FromNullableNullDecimal()
        {
            Assert.AreEqual(((decimal?)null).ToShort(-1), -1);
        }
        #endregion
        
    }
}
