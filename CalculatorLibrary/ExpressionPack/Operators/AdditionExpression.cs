namespace CalculatorLibrary.ExpressionPack.Operators
{
    public class AdditionExpression : BinaryExpression
    {
        private AdditionExpression()
        {
            
        }

        public AdditionExpression(IExpression left, IExpression right): base(left,right)
        {
            
        }

        protected override int EvalExecute(int left, int right)
        {
            return left + right;
        }
    }
}