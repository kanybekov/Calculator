using System;
using System.Reflection;
using CalculatorLibrary.Calculation;
using CalculatorLibrary.ExpressionPack;
using Moq;
using NUnit.Framework;
using Ninject;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculationTests
    {
        private IExpressionBuilder buider;

        [OneTimeSetUp]
        public void Setup()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            buider = kernel.Get<IExpressionBuilder>();
        }

        [TestCase("( 2 + 3 * 4 ) / 7", 2)]
        [TestCase("1 + 2 + 3 - 4 * 2", -2)]
        public void CalculateExpressionTest(string input, int expected)
        {
            buider.CreateExpression(input);
            var expression = buider.CreateExpression(input);

            var actual = expression.Evaluate();

            Assert.AreEqual(expected,actual);
        }

        [TestCase("1 + 3 - 2", 3)]
        public void Test2(string input)
        {
            Mock<IExpressionBuilder> mock = new Mock<IExpressionBuilder>();
        }
    }
}