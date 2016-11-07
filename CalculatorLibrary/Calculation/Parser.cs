using System.Collections.Generic;
using Calculator;

namespace CalculatorLibrary.Calculation
{
    public class Parser : IParser
    {
        public IEnumerable<ITerm> Parse(string input)
        {
            return new List<ITerm>();
        }
    }
}
