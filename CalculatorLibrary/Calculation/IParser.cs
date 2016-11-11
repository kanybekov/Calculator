using System.Collections.Generic;

namespace CalculatorLibrary.Calculation
{
    public interface IParser
    {
        IEnumerable<string> GeneratePostfixExpression(string input);
    }
}