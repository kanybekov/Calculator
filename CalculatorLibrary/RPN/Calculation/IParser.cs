using System.Collections.Generic;

namespace CalculatorLibrary.RPN.Calculation
{
    public interface IParser
    {
        IEnumerable<string> GeneratePostfixExpression(string input);
    }
}