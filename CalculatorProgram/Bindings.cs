using Ninject.Modules;
using CalculatorLibrary.Calculation;

namespace CalculatorProgram
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IParser>().To<IParser>();
            Bind<ICalculator>().To<MyCalculator>();
        }
    }
}