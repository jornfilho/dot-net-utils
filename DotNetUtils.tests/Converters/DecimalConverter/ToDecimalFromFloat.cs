using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.DecimalConverter
{
    [TestFixture]
    public class ToDecimalFromFloat
    {
        [TestCase(float.MinValue, -1, ExpectedResult = -1)]
        [TestCase(1.99f, 0, ExpectedResult = 1.99)]
        [TestCase(1.11f, 0, ExpectedResult = 1.11)]
        [TestCase(float.MaxValue, -1, ExpectedResult = -1)]
        public decimal ToDecimal_FromFloat(float floatValue, decimal defaultValue = 0)
        {
            return floatValue.ToDecimal(defaultValue);
        }

        [Test]
        public void ToDecimal_FromNegativeVerySmallFloat()
        {
            decimal exp = -10m / 3m;
            float dbl = -10f / 3f;

            Assert.That(exp, Is.EqualTo(dbl.ToDecimal()).Within(0.000001));
        }

        [Test]
        public void ToDecimal_FromNegativeSmallFloat()
        {
            decimal exp = -1000000.12345m;
            float dbl = -1000000.12345f;

            Assert.That(exp, Is.EqualTo(dbl.ToDecimal()).Within(0.01));
        }

        [Test]
        public void ToDecimal_FromSmallFloat()
        {
            decimal exp = 1000000.12345m;
            float dbl = 1000000.12345f;

            Assert.That(exp, Is.EqualTo(dbl.ToDecimal()).Within(0.01));
        }

        [Test]
        public void ToDecimal_FromVerySmallFloat()
        {
            decimal exp = 10m / 3m;
            float dbl = 10f / 3f;

            Assert.That(exp, Is.EqualTo(dbl.ToDecimal()).Within(0.000001));
        }

        [TestCase(float.MinValue, -1, ExpectedResult = -1)]
        [TestCase(1.99f, 0, ExpectedResult = 1.99)]
        [TestCase(1.11f, 0, ExpectedResult = 1.11)]
        [TestCase(float.MaxValue, -1, ExpectedResult = -1)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public decimal ToDecimal_FromNullableFloat(float? floatValue, decimal defaultValue = 0)
        {
            return floatValue.ToDecimal(defaultValue);
        }

        [Test]
        public void ToDecimal_FromNullableNegativeVerySmallFloat()
        {
            decimal exp = -10m / 3m;
            float? dbl = -10f / 3f;

            Assert.That(exp, Is.EqualTo(dbl.ToDecimal()).Within(0.000001));
        }

        [Test]
        public void ToDecimal_FromNullableNegativeSmallFloat()
        {
            decimal exp = -1000000.12345m;
            float? dbl = -1000000.12345f;

            Assert.That(exp, Is.EqualTo(dbl.ToDecimal()).Within(0.01));
        }

        [Test]
        public void ToDecimal_FromNullableSmallFloat()
        {
            decimal exp = 1000000.12345m;
            float? dbl = 1000000.12345f;

            Assert.That(exp, Is.EqualTo(dbl.ToDecimal()).Within(0.01));
        }

        [Test]
        public void ToDecimal_FromNullableVerySmallFloat()
        {
            decimal exp = 10m / 3m;
            float? dbl = 10f / 3f;

            Assert.That(exp, Is.EqualTo(dbl.ToDecimal()).Within(0.000001));
        }
    }
}
