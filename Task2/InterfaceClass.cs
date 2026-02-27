using static Task2.InterfaceClass;

namespace Task2
{
    public class InterfaceClass
    {
        public interface IFunction
        {
            double IFindRoot(double x);
        }
    }

    public class QuadraticFunction : IFunction
    {
        public double IFindRoot(double x)
        {
            return x * x - 8;
        }
    }
}
