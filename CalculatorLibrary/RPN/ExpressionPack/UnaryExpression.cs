namespace CalculatorLibrary.RPN.ExpressionPack
{
    public abstract class UnaryExpression : IExpression
    {
        protected UnaryExpression()
        {

        }

        public IExpression Operand { get; }

        protected UnaryExpression(IExpression operand)
        {
            Operand = operand;
        }

        public int Evaluate()
        {
           return EvalExecute(Operand.Evaluate());
        }

        protected abstract int EvalExecute(object eval);
    }
}