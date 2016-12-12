using CalculatorLibrary.Calculation;
using CalculatorLibrary.ExpressionPack;
using CalculatorLibrary.ExpressionPack.Operators;
using Ninject.Modules;

namespace CalculatorTests
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IExpressionContainer>().To<ExpressionContainer>()
                .OnActivation(container =>
                    container.AddExpression("+", typeof(AdditionExpression)))
                .OnActivation(container =>
                    container.AddExpression("-", typeof(SubstractionExpression)))
                .OnActivation(container =>
                    container.AddExpression("*", typeof(MultiplyExpression)))
                .OnActivation(container =>
                    container.AddExpression("/", typeof(DivisionExpression)));
            Bind<IParser>().To<Parser>();
            Bind<IExpressionBuilder>().To<ExpressionBuilder>();
        }
    }
}