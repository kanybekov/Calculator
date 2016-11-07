using System.Collections.Generic;
using Calculator;

namespace CalculatorLibrary.Calculation
{
    public interface IParser
    {
        IEnumerable<ITerm> Parse(string input);
    }
}