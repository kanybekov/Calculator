using CalculatorLibrary.Calculation;
using CalculatorLibrary.ExpressionPack;
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