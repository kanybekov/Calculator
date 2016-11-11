namespace CalculatorLibrary.RPN.ExpressionPack
{
    public class ConstantExpression : IExpression
    {
        private readonly int _value;

        public ConstantExpression(int value)
        {
            _value = value;
        }

        public int Evaluate()
        {
            return _value;
        }
    }
}