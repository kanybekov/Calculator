using System;
using System.Reflection;
using CalculatorLibrary;
using CalculatorLibrary.Calculation;
using CalculatorLibrary.ExpressionPack;
using CalculatorLibrary.ExpressionPack.Operators;
using Ninject;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var input = Console.ReadLine();

            var expressionContainer = kernel.Get<IExpressionContainer>();
            expressionContainer.AddExpression("+", typeof(AdditionExpression));
            expressionContainer.AddExpression("*", typeof(MultiplyExpression));
            expressionContainer.AddExpression("/", typeof(DivisionExpression));

            var parser = kernel.Get<IParser>();

            var expression = new ExpressionBuilder(parser, expressionContainer).CreateExpression(input);

            Console.WriteLine(expression.Evaluate());
        }
    }
}
