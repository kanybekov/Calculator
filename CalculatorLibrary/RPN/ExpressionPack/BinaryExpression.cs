namespace CalculatorLibrary.RPN.ExpressionPack
{
    public abstract class BinaryExpression : IExpression
    {
        protected BinaryExpression()
        {
            
        }
        
        public IExpression Left { get; }

        public IExpression Right { get; }

        protected BinaryExpression(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        public int Evaluate()
        {
            return EvalExecute(Left.Evaluate(), Right.Evaluate());
        }

        protected abstract int EvalExecute(int left, int right);
    }
}