using CalculatorLibrary.ExpressionPack;

namespace CalculatorLibrary.Calculation
{
    public interface IExpressionBuilder
    {
        IExpression CreateExpression(string input);
    }
}