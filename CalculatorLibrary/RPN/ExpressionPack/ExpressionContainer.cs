using System;
using System.Collections.Generic;

namespace CalculatorLibrary.RPN.ExpressionPack
{
    public class ExpressionContainer : IExpressionContainer
    {
        private readonly Dictionary<string, Type> _expressionDictionary = new Dictionary<string, Type>();

        public void AddExpression(string @operator, Type type)
        {
            _expressionDictionary.Add(@operator, type);   
        }

        public Type GetExpressionForOperator(string @operator)
        {
            if (_expressionDictionary.ContainsKey(@operator) == false)
            {
                throw new Exception("{@operator} isn't a supported operator");
            }

            return _expressionDictionary[@operator];
        }
    }

    public interface IExpressionContainer
    {
        Type GetExpressionForOperator(string @operator);
        void AddExpression(string @operator, Type type);
    }
}