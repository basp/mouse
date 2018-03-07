namespace Mouse
{
    public interface IArithmetic<U, V>
    {
        U Add(U x, V y);

        U Subtract(U x, V y);

        U Multiply(U x, V y);

        U Divide(U x, V y);
    }
}