namespace CalculatorLibrary.RPN.ExpressionPack.Operators
{
    public class MultiplyExpression:BinaryExpression
    {
        private MultiplyExpression()
        {
            
        }

        public MultiplyExpression(IExpression left, IExpression right):base(left, right)
        {
            
        }

        protected override int EvalExecute(int left, int right)
        { 
            return left * right;
        }
    }
}