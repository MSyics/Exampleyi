using MSyics.Traceyi;

namespace MSyics.Exampleyi
{
    internal abstract class Example
    {
        protected Tracer Tracer { get; } = Traceable.Get();
        public abstract string Name { get; }
        public abstract void Test();
    }
}
