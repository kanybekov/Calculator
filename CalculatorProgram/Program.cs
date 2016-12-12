using System;
using System.Reflection;
using CalculatorLibrary.Calculation;
using CalculatorLibrary.ExpressionPack;
using CalculatorLibrary.ExpressionPack.Operators;
using Ninject;

namespace CalculatorProgram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var input = Console.ReadLine();

            var expression = kernel.Get<IExpressionBuilder>().CreateExpression(input);

            Console.WriteLine(expression.Evaluate());
        }
    }
}
