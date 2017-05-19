using NUnit.Framework;

namespace CSharpCalculator.BO.Test
{
    [TestFixture]
    public class CalculatorServiceTest
    {
        [TestCase("1", "3", "13")]
        [TestCase("1", "24", "124")]
        [TestCase("0", "2", "2")]
        public void ParseInputTest(string previousState, string currentEntry, string expectedResult)
        {
            var expectedResult2 = null + "12";

            var currentResult = CalculatorService.ParseInput(previousState, currentEntry);

            Assert.That(currentResult, Is.EqualTo(expectedResult));
        }
    }
}
