using System;
using System.Collections.Generic;
using CalculatorLibrary.ExpressionPack;

namespace CalculatorLibrary.Calculation
{
    public class ExpressionBuilder : IExpressionBuilder
    {
        private readonly IParser _parser;
        private readonly IExpressionContainer _expressionContainer;

        public ExpressionBuilder(IParser parser, IExpressionContainer expressionContainer)
        {
            _parser = parser;
            _expressionContainer = expressionContainer;
        }

        public IExpression CreateExpression(string input)
        {
            var postfixExpression = _parser.GeneratePostfixExpression(input);

            var stack = new Stack<IExpression>();

            foreach (var token in postfixExpression)
            {
                var expression = Create(token, stack);
                stack.Push(expression);
            }

            if (stack.Count == 1)
            {
                return stack.Pop();
            }
            throw new InvalidOperationException("Syntax error");
        }

        private IExpression Create(string token, Stack<IExpression> expressionStack)
        {
            int value;

            if (int.TryParse(token, out value))
            {
                return new ConstantExpression(value);
            }

            return GetExpression(token, expressionStack);
        }

        private IExpression GetExpression(string symbol, Stack<IExpression> expressionStack)
        {
            var type = _expressionContainer.GetExpressionForOperator(symbol);

            if (typeof(UnaryExpression).IsAssignableFrom(type))
            {
                var operand = expressionStack.Pop();
                return Activator.CreateInstance(type, operand) as IExpression;
            }

            if (typeof(BinaryExpression).IsAssignableFrom(type))
            {
                var right = expressionStack.Pop();
                var left = expressionStack.Pop();

                return Activator.CreateInstance(type, left, right) as IExpression;
            }
            throw new NotSupportedException("Expression of type {type} nor supported.");
        }
    }
}