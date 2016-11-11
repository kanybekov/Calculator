namespace CalculatorLibrary.ExpressionPack.Operators
{
    public class SubstractionExpression : BinaryExpression
    {
        private SubstractionExpression()
        {
            
        }

        public SubstractionExpression(IExpression left, IExpression right) : base(left, right)
        {
            
        }

        protected override int EvalExecute(int left, int right)
        {
            return left - right;
        }
    }
}