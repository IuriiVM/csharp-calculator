using CSharpCalculator.BO;
using NUnit.Framework;

namespace CSharpCalculator.BO.Test
{
    [TestFixture]
    public class CalculatorServiceTest
    {
        [Test]
        public void ParseInputTest()
        {
            var expectedResult = "12";

            var currentResult = CalculatorService.ParseInput("1", "2");

            Assert.AreEqual(expectedResult, currentResult);
        }
    }
}
