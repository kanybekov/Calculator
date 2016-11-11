using CalculatorLibrary.RPN.Calculation;
using CalculatorLibrary.RPN.ExpressionPack;
using Ninject.Modules;

namespace CalculatorProgram
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IExpressionContainer>().To<ExpressionContainer>();
            Bind<IParser>().To<Parser>();
        }
    }
}