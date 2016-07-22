using DotNetUtils.Converters;
using NUnit.Framework;

namespace DotNetUtils.tests.Converters.DecimalConverter
{
    [TestFixture]
    public class ToDecimalFromDouble
    {
        [TestCase(double.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000000000.12345d, 0, ExpectedResult = -1000000000000.12345)]
        [TestCase(-1000000000.12345d, 0, ExpectedResult = -1000000000.12345)]
        [TestCase(-1000000.12345d, 0, ExpectedResult = -1000000.12345)]
        [TestCase(-1000.12345d, 0, ExpectedResult = -1000.12345)]
        [TestCase(1.99d, 0, ExpectedResult = 1.99)]
        [TestCase(1.11d, 0, ExpectedResult = 1.11)]
        [TestCase(1000.12345d, 0, ExpectedResult = 1000.12345)]
        [TestCase(1000000.12345d, 0, ExpectedResult = 1000000.12345)]
        [TestCase(1000000000.12345d, 0, ExpectedResult = 1000000000.12345)]
        [TestCase(1000000000000.12345d, 0, ExpectedResult = 1000000000000.12345)]
        [TestCase(double.MaxValue, 1, ExpectedResult = 1)]
        public decimal ToDecimal_FromDouble(double doubleValue, decimal defaultValue)
        {
            return doubleValue.ToDecimal(defaultValue);
        }

        [Test]
        public void ToDecimal_FromNegativeVerySmallDouble()
        {
            decimal exp = -10m/3m;
            double dbl = -10d/3d;

            Assert.That(exp, Is.EqualTo(dbl.ToDecimal()).Within(0.000001));
        }

        [Test]
        public void ToDecimal_FromVerySmallDouble()
        {
            decimal exp = 10m / 3m;
            double dbl = 10d / 3d;

            Assert.That(exp, Is.EqualTo(dbl.ToDecimal()).Within(0.000001));
        }

        [TestCase(double.MinValue, -1, ExpectedResult = -1)]
        [TestCase(-1000000000000.12345d, 0, ExpectedResult = -1000000000000.12345)]
        [TestCase(-1000000000.12345d, 0, ExpectedResult = -1000000000.12345)]
        [TestCase(-1000000.12345d, 0, ExpectedResult = -1000000.12345)]
        [TestCase(-1000.12345d, 0, ExpectedResult = -1000.12345)]
        [TestCase(1.99d, 0, ExpectedResult = 1.99)]
        [TestCase(1.11d, 0, ExpectedResult = 1.11)]
        [TestCase(1000.12345d, 0, ExpectedResult = 1000.12345)]
        [TestCase(1000000.12345d, 0, ExpectedResult = 1000000.12345)]
        [TestCase(1000000000.12345d, 0, ExpectedResult = 1000000000.12345)]
        [TestCase(1000000000000.12345d, 0, ExpectedResult = 1000000000000.12345)]
        [TestCase(double.MaxValue, -1, ExpectedResult = -1)]
        [TestCase(null, -1, ExpectedResult = -1)]
        public decimal ToDecimal_FromNullableDouble(double? doubleValue, decimal defaultValue)
        {
            return doubleValue.ToDecimal(defaultValue);
        }

        [Test]
        public void ToDecimal_FromNullableNegativeVerySmallDouble()
        {
            decimal exp = -10m / 3m;
            double? dbl = -10d / 3d;

            Assert.That(exp, Is.EqualTo(dbl.ToDecimal()).Within(0.000001));
        }

        [Test]
        public void ToDecimal_FromNullableVerySmallDouble()
        {
            decimal exp = 10m / 3m;
            double? dbl = 10d / 3d;

            Assert.That(exp, Is.EqualTo(dbl.ToDecimal()).Within(0.000001));
        }

        
    }
}
