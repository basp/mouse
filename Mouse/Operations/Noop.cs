namespace Mouse.Operations
{
    public class Noop<T> : IOperation<T>
    {
        public T Execute(T state) => state;
    }
}