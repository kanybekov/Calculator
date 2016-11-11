namespace CalculatorLibrary.RPN.ExpressionPack.Operators
{
    public class DivisionExpression:BinaryExpression
    {
        private DivisionExpression()
        {
            
        }

        public DivisionExpression(IExpression left, IExpression right) : base(left, right)
        {
            
        }

        protected override int EvalExecute(int left, int right)
        {
            return left / right;
        }
    }
}