namespace Task2
{
    public interface Inrterface
    {
        double IFindRoot(double x);
    }

    public class QuadraticFunction : Inrterface
    {
        public double IFindRoot(double x)
        {
            return x * x - 8;
        }
    }
}
