namespace Mouse
{
    using System;
    using System.Diagnostics;

    public class VM<T>
    {
        private T state;

        public T State => this.state;

        public VM(T initialState)
        {
            this.state = initialState;
        }

        public TimeSpan Execute(IOperation<T> op) =>
            Swatch(() => op.Execute(this.State), out this.state);

        private TimeSpan Swatch(Func<T> f, out T result)
        {
            var sw = new Stopwatch();
            sw.Start();
            result = f();
            sw.Stop();
            return sw.Elapsed;
        }
    }
}
