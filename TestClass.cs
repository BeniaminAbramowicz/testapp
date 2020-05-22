using NUnit.Framework;

namespace TestApp
{
    [TestFixture]
    class TestClass
    {
        [Test]
        [Category("pass")]
        [TestCase(3, 1.5, 0.66)]
        [TestCase(10, 1.5, 0.3)]
        [TestCase(15, 1.5, 0.34)]
        [TestCase(12, 1.5, 0.9)]
        [TestCase(34, 1.5, 0.1)]
        [TestCase(22, 1.5, 0.25)]
        [TestCase(6, 1.5, 0.8)]
        public void CountResult_CorrectData_ReturnGreaterThanZeroResult(int h, double w, double b)
        {
            int result = Algorythm.CountResult(h, w, b);
            Assert.Greater(result, 0);
        }

        [Test]
        [Category("pass")]
        [TestCase(1, 1.5, 0.66)]
        [TestCase(0, 1.5, 0.5)]
        [TestCase(3, 1.5, 1)]
        [TestCase(5, 1.5, 0)]
        public void CountResult_IncorrectData_ReturnMinusOneResult(int h, double w, double b)
        {
            int result = Algorythm.CountResult(h, w, b);
            Assert.AreEqual(result, -1);
        }
    }
}
