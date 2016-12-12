using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using CalculatorLibrary.Calculation;
using CalculatorLibrary.ExpressionPack;
using Moq;
using NUnit.Framework;
using Ninject;

namespace CalculatorTests
{
    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class CalculationTests
    {
        private IExpressionBuilder expressionBuilder;

        [OneTimeSetUp]
        public void Setup()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            expressionBuilder = kernel.Get<IExpressionBuilder>();
        }

        [TestCase("( 2 + 3 * 4 ) / 7", 2)]
        [TestCase("1 + 2 + 3 - 4 * 2", -2)]
        public void CalculateExpressionTest(string input, int expected)
        {
            expressionBuilder.CreateExpression(input);
            var expression = expressionBuilder.CreateExpression(input);

            var actual = expression.Evaluate();

            Assert.AreEqual(expected,actual);
        }
    }
}