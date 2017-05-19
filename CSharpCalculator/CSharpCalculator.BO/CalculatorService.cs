
namespace CSharpCalculator.BO
{
    public static class CalculatorService
    {
        public static string ParseInput(string previousState, string currentEntry)
        {
            return previousState + currentEntry;
        }
    }
}
