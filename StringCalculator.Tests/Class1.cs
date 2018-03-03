using NUnit.Framework;
using SimpleStringCalculator;

namespace SimpleStringCalculator.Tests
{
    [TestFixture]
    public class StringCalculatorTest
    {
        [Test]
        public void Entering_zero_returns_zero()
        {
           var result = SimpleStringCalculator.Add(string.Empty);
            Assert.AreEqual(0, result);
        }
    }
}
