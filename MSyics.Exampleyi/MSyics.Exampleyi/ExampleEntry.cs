using MSyics.Traceyi;
using System.Collections.Generic;

public abstract class ExampleEntry
{
    public ExampleEntry()
    {
        Traceable.Add(TraceConfig);
    }

    virtual protected string TraceConfig => "Traceyi.json";
    protected Tracer Tracer { get; } = Traceable.Get();
    private List<Example> Examples { get; } = new List<Example>();

    public ExampleEntry Add<T>() where T : Example, new()
    {
        Examples.Add(new T());
        return this;
    }

    public void Test()
    {
        foreach (var item in Examples)
        {
            using (Tracer.Scope(item.Name))
            {
                item.Test();
            }
        }
        Traceable.Shutdown();
    }
}
