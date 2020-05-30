using BasicTextCalculator;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RealityTest()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void CantDivideByZero()
        {
            var c = new Calculator();
            try
            {
                c.DivideNumbers(1, 0);
                Assert.Fail();
            }
            catch(System.DivideByZeroException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void OnePlusOneIsTwo()
        {
            var c = new Calculator();

            var result = c.AddNumbers(1, 1);

            Assert.AreEqual(2, result);
        }
    }
}