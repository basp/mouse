namespace Mouse
{
    public interface IOperation<T>
    {
        T Execute(T state);
    }
}